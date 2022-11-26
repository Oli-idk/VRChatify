using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace VRChatify
{
    public static class LimeLogger
    {
        #region https://github.com/NYAN-x-CAT/LimeLogger/blob/master/LimeLogger/LimeLogger.cs 
    
        public static string GetActiveWindowTitle()
        {
            try
            {
                IntPtr hwnd = GetForegroundWindow();
                GetWindowThreadProcessId(hwnd, out uint pid);
                Process p = Process.GetProcessById((int)pid);
                string title = p.MainWindowTitle;
                if (string.IsNullOrWhiteSpace(title))
                    title = p.ProcessName;
                return title;
            }
            catch (Exception)
            {
                return "???";
            }
        }
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        #endregion

    }
}
