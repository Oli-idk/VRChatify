using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRChatify;
using System.Timers;
namespace VRChatify
{
    public partial class MainWindow : Form
    {
        private static System.Timers.Timer spotifyTimer;
        private static string oscText = "Just Started VRChatify";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "VRChatify";
        }

        private void presenceToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (presenceToggle.Checked)
            {
                VRChatifyUtils.InitRPC();
            }
            else
            {
                VRChatifyUtils.KillRPC();
            }
        }

        private void spotifyToggle_CheckedChanged(object sender, EventArgs e)
        {
            //if checkbox checked start 5 second repeating timer else stop it
            if (spotifyToggle.Checked)
            {
                VRChatify.UpdateOSC(oscText);
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
                .Replace("{SPOTIFY}", VRChatify.GetSpotifySong())
                .Replace("{CPU}", Math.Round(VRChatify.GetCurrentCpuUsage()).ToString())
                .Replace("{GPU}", Math.Round(VRChatify.GetGPUUsage()).ToString())
                .Replace("{RAM}", VRChatify.GetRamUsage().ToString())
                .Replace("{TIME}", DateTime.Now.ToString("h:mm:ss tt"));
            VRChatify.UpdateOSC(oscMsg);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //replace {CPU} with Math.Round(GetCurrentCpuUsage())

            oscText = textBox1.Text;
        }
    }
}
