using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CoreOSC;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsMediaController;
using static WindowsMediaController.MediaManager;
using Windows.Media;
using Windows.Storage.Streams;

namespace VRChatify
{
    public static class VRChatify
    {
        public static bool debugging = false;
        public static string Version = "1.0.2";
        public static UDPSender oscSender;
        public static UDPListener oscReceiver;
        private static readonly MediaManager mediaManager = new MediaManager();
        private static MainWindow mainWindow;
        #nullable enable
        private static MediaSession? currentSession = null;
        #nullable disable
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
            mediaManager.Start();
            VRChatifyUtils.Logo();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new MainWindow();
            mediaManager.OnAnySessionOpened += MediaManager_OnAnySessionOpened;
            mediaManager.OnAnySessionClosed += MediaManager_OnAnySessionClosed;
            Application.Run(mainWindow);
        }

        private static void MediaManager_OnAnySessionOpened(MediaSession mediaSession)
        {
            VRChatifyUtils.DebugLog($"Session Opened: {mediaSession.Id}");
            mainWindow.UpdateSessionList();
        }
        
        private static void MediaManager_OnAnySessionClosed(MediaSession mediaSession)
        {
            VRChatifyUtils.DebugLog($"Session Closed: {mediaSession.Id}");
            mainWindow.UpdateSessionList();
        }
        
        private static MediaSession GetCurrentSession()
        {
            if (currentSession == null)
            {
                try
                {
                    return currentSession = mediaManager.CurrentMediaSessions.First().Value;
                }
                catch (InvalidOperationException)
                {
                    VRChatifyUtils.DebugLog("No session found");
                    return null;
                }
            }
            return currentSession;
        }

        public static List<Button> GenerateSessionButtons()
        {
            List<Button> buttons = new List<Button>();
            int BaseLocX = 3;
            int BaseLocY = 15;
            foreach (var session in mediaManager.CurrentMediaSessions)
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
            currentSession = mediaManager.CurrentMediaSessions[btn.Name];
            VRChatifyUtils.DebugLog($"Current session set to: {currentSession.Id}");
        }
        
        public static string GetSongName()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.Title;
            }
            return "Unable to get Title";
        }

        public static string GetSongArtist()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.Artist;
            }
            return "Unable to get Author";
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
                    if (currentSession == null)
                    {
                        currentSession = mediaManager.CurrentMediaSessions.First().Value;
                    }
                    await currentSession.ControlSession.TrySkipPreviousAsync();
                    await currentSession.ControlSession.TrySkipPreviousAsync();
                }
                else if (address == "/avatar/parameters/skip")
                {
                    VRChatifyUtils.DebugLog("Skip");
                    if (currentSession == null)
                    {
                        currentSession = mediaManager.CurrentMediaSessions.First().Value;
                    }
                    await currentSession.ControlSession.TrySkipNextAsync();
                }
                else if (address == "/avatar/parameters/paused")
                {
                    VRChatifyUtils.DebugLog("paused");
                    if (currentSession == null)
                    {
                        currentSession = mediaManager.CurrentMediaSessions.First().Value;
                    }
                    await currentSession.ControlSession.TryTogglePlayPauseAsync();
                }
                return Task.CompletedTask;
            });
        }

    }
}