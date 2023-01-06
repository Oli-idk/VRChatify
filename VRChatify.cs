using System;
using System.Collections.Generic;
using CoreOSC;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace VRChatify
{
    public static class VRChatify
    {
        public static bool debugging = false;
        public static string Version = "1.0.4";
        public static UDPSender oscSender;
        public static UDPListener oscReceiver;
        private static MainWindow mainWindow;
        public static VMediaManager mediaManager;

        public static string CurrentSongCheck = null;

        public static string CurrentSong = null;

        public static string CurrentSound = null;

        public static string ClanTag = "";
        public static List<string> ClanTagStrings;
        public static int ClanTagIndex = 0;

        public static void SendChatMessage(string message)
        {
            oscSender.Send(new OscMessage("/chatbox/input", message, true, true));
            VRChatifyUtils.DebugLog("Updated ChatBox!");

            CurrentSongCheck = CurrentSong;
        }
        
        static void Main()
        {
            oscSender = new UDPSender("127.0.0.1", 9000);
            oscReceiver = new UDPListener(9001, OnOscPacket);
            mediaManager = new VMediaManager();
            mediaManager.Init();
            VRChatifyUtils.Logo();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }

        public static List<Button> GenerateSessionButtons()
        {
            List<Button> buttons = new List<Button>();
            int BaseLocX = 3;
            int BaseLocY = 15;
            foreach (var session in mediaManager.GetMediaManager().CurrentMediaSessions)
            {
                VRChatifyUtils.DebugLog("Generating Button");
                Button button = new Button
                {
                    ForeColor = System.Drawing.SystemColors.ControlText,
                    Location = new System.Drawing.Point(BaseLocX, BaseLocY),
                    Name = session.Key,
                    Size = new System.Drawing.Size(178, 23),
                    TabIndex = 2,
                    Text = session.Value.Id,
                    UseVisualStyleBackColor = true
                };
                button.Click += new EventHandler(DynamicButton_Click);
                BaseLocY += 25;
                buttons.Add(button);
            }
            return buttons;
        }

        private static void DynamicButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            mediaManager.setCurrentSession(mediaManager.GetMediaManager().CurrentMediaSessions[btn.Name]);
            VRChatifyUtils.DebugLog($"Current session set to: {btn.Name}");
        }

        private static void OnOscPacket(OscPacket packet)
        {
            if (!(packet is OscMessage message)
                || message.Address == null
                || message.Arguments == null
                || message.Arguments.Count == 0)
            {
                return;
            }
            var value = message.Arguments[0];
            if (value == null || !(value is bool boolean) || !boolean)
            {
                return;
            }

            Task.Run(async () => {
                var address = message.Address;
                if (address == "/avatar/parameters/back")
                {
                    VRChatifyUtils.DebugLog("Back");
                    await mediaManager.GetCurrentSession()?.ControlSession.TrySkipPreviousAsync();
                }
                else if (address == "/avatar/parameters/skip")
                {
                    VRChatifyUtils.DebugLog("Skip");
                    await mediaManager.GetCurrentSession()?.ControlSession.TrySkipNextAsync();
                }
                else if (address == "/avatar/parameters/paused")
                {
                    VRChatifyUtils.DebugLog("paused");
                    await mediaManager.GetCurrentSession()?.ControlSession.TryTogglePlayPauseAsync();
                }
                return Task.CompletedTask;
            });
        }

        public static MainWindow GetMainWindow()
        {
            return mainWindow;
        }
        

    }
}