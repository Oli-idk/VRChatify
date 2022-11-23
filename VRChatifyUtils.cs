using System;
using Console = Colorful.Console;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Runtime.InteropServices;

namespace VRChatify
{
    public static class VRChatifyUtils
    {
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
        public static void DebugLog(string Message)
        {
            if (VRChatify.debugging)
            {
                Console.Write("[");
                Console.Write($"{DateTime.Now}", System.Drawing.Color.Yellow);
                Console.Write("] ");

                Console.Write("[");
                Console.Write("Debug", System.Drawing.Color.Yellow);
                Console.Write("] ");
                Console.Write(Message);
                Console.WriteLine();
            }
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
    }
}
