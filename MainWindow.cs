using System;
using System.Windows.Forms;
using System.Timers;

namespace VRChatify
{
    public partial class MainWindow : Form
    {
        private static System.Timers.Timer OSCTimer;
        private static string oscText = "{SONG} - {ARTIST} | CPU: {CPU}% | RAM: {RAM}% | GPU: {GPU}% | Time: {TIME} | {CLANTAG}";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set window title to app version
            Text = $"VRChatify: {VRChatify.Version}";
            VRChatify.ClanTagStrings = VRChatifyUtils.ClanTagText("VRChatify");
            UpdateSessionList();
        }

        private void PresenceToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (presenceToggle.Checked)
            {
                PresenceManager.InitRPC();
            }
            else
            {
                PresenceManager.KillRPC();
            }
        }

        private void OSCToggle_CheckedChanged(object sender, EventArgs e)
        {
            //if checkbox checked start 5 second repeating timer else stop it
            if (OSCToggle.Checked)
            {
                var oscMsg = oscText
                    .Replace("{SONG}", VRChatify.mediaManager.GetSongName())
                    .Replace("{ARTIST}", VRChatify.mediaManager.GetSongArtist())
                    .Replace("{SPOTIFY}", VRChatifyUtils.GetSpotifySong())
                    .Replace("{CPU}", Math.Round(VRChatifyUtils.GetCpuUsage()).ToString())
                    .Replace("{GPU}", Math.Round(VRChatifyUtils.GetGPUUsage()).ToString())
                    .Replace("{RAM}", VRChatifyUtils.GetRamUsage().ToString())
                    .Replace("{TIME}", DateTime.Now.ToString("h:mm:ss tt"))
                    .Replace("{WINDOW}", VRChatifyUtils.GetActiveWindowTitle())
                    .Replace("{DURATION}", VRChatify.mediaManager.GetSongDuration().ToString(@"mm\:ss"))
                    .Replace("{POSITION}", VRChatify.mediaManager.GetCurrentSongTime().ToString(@"mm\:ss"))
                    .Replace("{CLANTAG}", VRChatify.ClanTagStrings[VRChatify.ClanTagIndex]);
                    
                VRChatify.SendChatMessage(oscMsg);
                SetTimer();
            }
            else
            {
                OSCTimer.Stop();
                OSCTimer.Dispose();
            }
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            OSCTimer = new System.Timers.Timer(2500);
            // Hook up the Elapsed event for the timer. 
            OSCTimer.Elapsed += OnTimedEvent;
            OSCTimer.AutoReset = true;
            OSCTimer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {   
            var oscMsg = oscText
                    .Replace("{SONG}", VRChatify.mediaManager.GetSongName())
                    .Replace("{ARTIST}", VRChatify.mediaManager.GetSongArtist())
                    .Replace("{SPOTIFY}", VRChatifyUtils.GetSpotifySong())
                    .Replace("{CPU}", Math.Round(VRChatifyUtils.GetCpuUsage()).ToString())
                    .Replace("{GPU}", Math.Round(VRChatifyUtils.GetGPUUsage()).ToString())
                    .Replace("{RAM}", VRChatifyUtils.GetRamUsage().ToString())
                    .Replace("{TIME}", DateTime.Now.ToString("h:mm:ss tt"))
                    .Replace("{WINDOW}", VRChatifyUtils.GetActiveWindowTitle())
                    .Replace("{DURATION}", VRChatify.mediaManager.GetSongDuration().ToString(@"mm\:ss"))
                    .Replace("{POSITION}", VRChatify.mediaManager.GetCurrentSongTime().ToString(@"mm\:ss"))
                    .Replace("{CLANTAG}", VRChatify.ClanTagStrings[VRChatify.ClanTagIndex]);
            VRChatify.SendChatMessage(oscMsg);
            if(VRChatify.ClanTagIndex >= VRChatify.ClanTagStrings.Count - 1)
            {
                VRChatify.ClanTagIndex = 0;
            }
            else
            {
                VRChatify.ClanTagIndex += 1;
            }
        }

        private void OSCMessage_TextChanged(object sender, EventArgs e)
        {
            oscText = oscMessage.Text;
        }

        private void PresenceUpdateButton_Click(object sender, EventArgs e)
        {
            PresenceManager.UpdateDetails(presenceDetails.Text);
        }

        private void ForceUpdateSessions_Click(object sender, EventArgs e) => UpdateSessionList();
        
        public void UpdateSessionList()
        {
            SessionHolder.Invoke(new MethodInvoker(delegate { SessionHolder.Controls.Clear(); }));
            foreach (var item in VRChatify.GenerateSessionButtons())
            {
                VRChatifyUtils.DebugLog($"Adding Buton {item.Text}");
                SessionHolder.Invoke(new MethodInvoker(delegate { SessionHolder.Controls.Add(item); }));
                VRChatifyUtils.DebugLog($"Added Buton {item.Text}");
            }
        }

        private void DebugLogging_CheckedChanged(object sender, EventArgs e)
        {
            VRChatify.debugging = DebugLogging.Checked;
        }

        private void ClanTag_TextChanged(object sender, EventArgs e)
        {
            VRChatify.ClanTagStrings = VRChatifyUtils.ClanTagText(ClanTag.Text);
            VRChatify.ClanTagIndex = 0;
        }
    }
}
