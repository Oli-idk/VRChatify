using System;
using Console = Colorful.Console;
using DiscordRPC;
using DiscordRPC.Logging;

namespace VRChatify
{
    public static class VRChatifyUtils
    {
        public static DiscordRpcClient client;
        public static void Error(string Message)
        {
            Console.Write($"{Message}\n", System.Drawing.Color.Red);
        }
        public static void Log(string Message)
        {
            Console.Write("[");
            Console.Write($"{DateTime.Now}", System.Drawing.Color.Green);
            Console.Write("] ");

            Console.Write("[");
            Console.Write("VRChatify", System.Drawing.Color.Green);
            Console.Write("] ");
            Console.Write(Message);
            Console.WriteLine();
        }
        public static void Logo()
        {

            Console.WriteLine("██    ██ ██████   ██████ ██   ██  █████  ████████ ██ ███████ ██    ██", System.Drawing.Color.Green);
            Console.WriteLine("██    ██ ██   ██ ██      ██   ██ ██   ██    ██    ██ ██       ██  ██ ", System.Drawing.Color.Green);
            Console.WriteLine("██    ██ ██████  ██      ███████ ███████    ██    ██ █████     ████  ", System.Drawing.Color.Green);
            Console.WriteLine(" ██  ██  ██   ██ ██      ██   ██ ██   ██    ██    ██ ██         ██   ", System.Drawing.Color.Green);
            Console.WriteLine("  ████   ██   ██  ██████ ██   ██ ██   ██    ██    ██ ██         ██   ", System.Drawing.Color.Green);
        }
        public static void Clear()
        {
            Console.Clear();
            Console.WriteLine("██    ██ ██████   ██████ ██   ██  █████  ████████ ██ ███████ ██    ██", System.Drawing.Color.Green);
            Console.WriteLine("██    ██ ██   ██ ██      ██   ██ ██   ██    ██    ██ ██       ██  ██ ", System.Drawing.Color.Green);
            Console.WriteLine("██    ██ ██████  ██      ███████ ███████    ██    ██ █████     ████  ", System.Drawing.Color.Green);
            Console.WriteLine(" ██  ██  ██   ██ ██      ██   ██ ██   ██    ██    ██ ██         ██   ", System.Drawing.Color.Green);
            Console.WriteLine("  ████   ██   ██  ██████ ██   ██ ██   ██    ██    ██ ██         ██   ", System.Drawing.Color.Green);

        }

        public static void InitRPC()
        {

            client = new DiscordRpcClient("1044239130881687652")
            {
                //Set the logger
                Logger = new ConsoleLogger() { Level = LogLevel.Warning }
            };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                VRChatifyUtils.Log($"Received Ready from user {e.User.Username}");
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                VRChatifyUtils.Log($"Received Update! {e.Presence}");
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = "Using VRchatify",
                State = "VRchatify by bwmp",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "https://files.akiradev.xyz/VRchatify/Icon1.gif",
                    LargeImageText = "Vrchatify by bwmp",
                    SmallImageKey = "https://files.akiradev.xyz/VRchatify/VRChatify.png"
                },
                Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button()
                    {
                        Label = "Github",
                        Url = "https://github.com/Oli-idk/VRChatify"
                    }
                }
            });
        }
        public static void KillRPC()
        {
            client.Dispose();
        }
    }
}
