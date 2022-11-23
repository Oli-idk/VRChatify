using System;
using System.Windows.Forms;
using System.Timers;
using System.Reflection;

namespace VRChatify
{
    public partial class MainWindow : Form
    {
        private static System.Timers.Timer spotifyTimer;
        private static string oscText = "{SONG} - {ARTIST} | CPU: {CPU}% | RAM: {RAM}% | GPU: {GPU}% | Time: {TIME}";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set window title to app version
            this.Text = $"VRChatify: {VRChatify.Version}";
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

        private void SpotifyToggle_CheckedChanged(object sender, EventArgs e)
        {
            //if checkbox checked start 5 second repeating timer else stop it
            if (spotifyToggle.Checked)
            {
                VRChatify.SendChatMessage(oscText);
                SetTimer();
            }
            else
            {
                spotifyTimer.Stop();
                spotifyTimer.Dispose();
            }
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            spotifyTimer = new System.Timers.Timer(5000);
            // Hook up the Elapsed event for the timer. 
            spotifyTimer.Elapsed += OnTimedEvent;
            spotifyTimer.AutoReset = true;
            spotifyTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            var oscMsg = oscText
                .Replace("{SONG}", VRChatify.GetSongName())
                .Replace("{ARTIST}", VRChatify.GetSongArtist())
                .Replace("{CPU}", Math.Round(VRChatify.GetCpuUsage()).ToString())
                .Replace("{GPU}", Math.Round(VRChatify.GetGPUUsage()).ToString())
                .Replace("{RAM}", VRChatify.GetRamUsage().ToString())
                .Replace("{TIME}", DateTime.Now.ToString("h:mm:ss tt"));
            VRChatify.SendChatMessage(oscMsg);
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

        public void DynamicButton_Click(object sender, EventArgs e)
        {
        }

        public void UpdateSessionList()
        {
            SessionHolder.Controls.Clear();
            foreach (var item in VRChatify.GenerateSessionButtons())
            {
                VRChatifyUtils.DebugLog("Adding Buton");
                SessionHolder.Controls.Add(item);
                VRChatifyUtils.DebugLog("Added Button");
            }
        }

        private void DebugLogging_CheckedChanged(object sender, EventArgs e)
        {
            VRChatify.debugging = DebugLogging.Checked;
        }
    }
}
