using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Threading;
using CoreOSC;
using System.Windows.Forms;
using Timer = System.Threading.Timer;
namespace VRChatify
{
    public static class VRChatify
    {

        public static float GetGPUUsage()
        {
            try
            {
                var category = new PerformanceCounterCategory("GPU Engine");
                var counterNames = category.GetInstanceNames();
                var gpuCounters = new List<PerformanceCounter>();
                var result = 0f;

                foreach (string counterName in counterNames)
                {
                    if (counterName.EndsWith("engtype_3D"))
                    {
                        foreach (PerformanceCounter counter in category.GetCounters(counterName))
                        {
                            if (counter.CounterName == "Utilization Percentage")
                            {
                                gpuCounters.Add(counter);
                            }
                        }
                    }
                }

                gpuCounters.ForEach(x =>
                {
                    _ = x.NextValue();
                });

                Thread.Sleep(1000);

                gpuCounters.ForEach(x =>
                {
                    result += x.NextValue();
                });

                return result;
            }
            catch
            {
                VRChatifyUtils.Error("[Error] Grabbing gpu usage");
                return 0f;
            }
        }
        public static UDPSender oscSender;
        public static UDPListener oscReceiver;
        public static string GetSpotifySong()
        {
            //https://stackoverflow.com/questions/37854194/get-current-song-name-for-a-local-application
            var SpotifyProcess = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));
            if (SpotifyProcess == null)
            {
                VRChatifyUtils.Error("[Error] Spotify is not opened");
            }
            CurrentSong = SpotifyProcess.MainWindowTitle;
            if (CurrentSong == "Spotify Free" || CurrentSong == "Spotify Premium")
            {
                return "Idling on Spotify";
            }
            if (CurrentSong == "Spotify" || CurrentSong == "Advertisement")
            {
                return "Listening To A Ad :(";

            }
            return SpotifyProcess.MainWindowTitle;
        }
        public static float GetCurrentCpuUsage()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue();
            Thread.Sleep(1000);
            return (dynamic)cpuCounter.NextValue();
        }
        public static double GetRamUsage()
        {
            var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            ManagementClass cimobject1 = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc1 = cimobject1.GetInstances();
            double available = 0, capacity = 0;
            foreach (ManagementObject mo1 in moc1)
            {
                capacity += ((Math.Round(Int64.Parse(mo1.Properties["Capacity"].Value.ToString()) / 1024 / 1024 / 1024.0, 1)));
            }
            moc1.Dispose();
            cimobject1.Dispose();


            ManagementClass cimobject2 = new ManagementClass("Win32_PerfFormattedData_PerfOS_Memory");
            ManagementObjectCollection moc2 = cimobject2.GetInstances();
            foreach (ManagementObject mo2 in moc2)
            {
                available += ((Math.Round(Int64.Parse(mo2.Properties["AvailableMBytes"].Value.ToString()) / 1024.0, 1)));

            }
            moc2.Dispose();
            cimobject2.Dispose();
            return Math.Round((capacity - available) / capacity * 100, 0);
        }
        public static string CurrentSongCheck = null;

        public static string CurrentSong = null;

        public static string CurrentSound = null;

        public static void UpdateOSC(string message)
        {
            oscSender.Send(new OscMessage("/chatbox/input", message, true, true));
            VRChatifyUtils.Log("Sent Current Song!");

            CurrentSongCheck = CurrentSong;
        }
        static void Main()
        {
            oscSender = new UDPSender("127.0.0.1", 9000);
            oscReceiver = new UDPListener(9001);
            VRChatifyUtils.Logo();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
