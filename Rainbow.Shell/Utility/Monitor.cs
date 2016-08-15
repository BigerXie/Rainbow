using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;

namespace Rainbow.Shell.Utility
{
    /// <summary>
    /// WPF replacemenet for Screen.AllScreens():
    /// http://www.wpftutorial.net/screenresolutions.html
    /// Multiple Display Monitors Functions:
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/dd145072(v=vs.85).aspx
    /// pinvoke-monitorfromwindow (user32):
    /// http://www.pinvoke.net/default.aspx/user32/monitorfromwindow.html?diff=y
    /// </summary>
    public class Monitor
    {
        #region Dll imports

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [ResourceExposure(ResourceScope.None)]
        private static extern bool GetMonitorInfo
                      (HandleRef hmonitor, [In, Out]MonitorInfoEx info);

        [DllImport("user32.dll", ExactSpelling = true)]
        [ResourceExposure(ResourceScope.None)]
        private static extern bool EnumDisplayMonitors
             (HandleRef hdc, IntPtr rcClip, MonitorEnumProc lpfnEnum, IntPtr dwData);

        [DllImport("user32.dll")]
        [ResourceExposure(ResourceScope.None)]
        private static extern IntPtr MonitorFromWindow(IntPtr hwnd, uint dwFlags);

        private delegate bool MonitorEnumProc
                     (IntPtr monitor, IntPtr hdc, IntPtr lprcMonitor, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 4)]
        private class MonitorInfoEx
        {
            internal int cbSize = Marshal.SizeOf(typeof(MonitorInfoEx));
            internal Rect rcMonitor = new Rect();
            internal Rect rcWork = new Rect();
            internal int dwFlags = 0;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            internal char[] szDevice = new char[32];
        }

        private const int MonitorinfofPrimary = 0x00000001;
        private const int MONITOR_DEFAULTTONULL = 0;
        private const int MONITOR_DEFAULTTOPRIMARY = 1;
        private const int MONITOR_DEFAULTTONEAREST = 2;
        #endregion

        public static HandleRef NullHandleRef = new HandleRef(null, IntPtr.Zero);

        public System.Windows.Rect Bounds { get; private set; }
        public System.Windows.Rect WorkingArea { get; private set; }
        public string Name { get; private set; }

        public bool IsPrimary { get; private set; }

        private Monitor(IntPtr monitor, IntPtr hdc)
        {
            var info = new MonitorInfoEx();
            GetMonitorInfo(new HandleRef(null, monitor), info);
            Bounds = new System.Windows.Rect(
                        info.rcMonitor.left, info.rcMonitor.top,
                        info.rcMonitor.right - info.rcMonitor.left,
                        info.rcMonitor.bottom - info.rcMonitor.top);
            WorkingArea = new System.Windows.Rect(
                        info.rcWork.left, info.rcWork.top,
                        info.rcWork.right - info.rcWork.left,
                        info.rcWork.bottom - info.rcWork.top);
            IsPrimary = ((info.dwFlags & MonitorinfofPrimary) != 0);
            Name = new string(info.szDevice).TrimEnd((char)0);
        }

        public static IEnumerable<Monitor> AllMonitors
        {
            get
            {
                var closure = new MonitorEnumCallback();
                var proc = new MonitorEnumProc(closure.Callback);
                EnumDisplayMonitors(NullHandleRef, IntPtr.Zero, proc, IntPtr.Zero);
                return closure.Monitors.Cast<Monitor>();
            }
        }

        public static Monitor GetCurrentMonitor(Window window)
        {
            WindowInteropHelper wndHelper = new WindowInteropHelper(window);//Get Window Handle
            IntPtr monitor = MonitorFromWindow(wndHelper.Handle, MONITOR_DEFAULTTONEAREST);
            Monitor result = new Monitor(monitor, IntPtr.Zero);
            return result;
        }

        private class MonitorEnumCallback
        {
            public ArrayList Monitors { get; private set; }

            public MonitorEnumCallback()
            {
                Monitors = new ArrayList();
            }

            public bool Callback(IntPtr monitor, IntPtr hdc,
                           IntPtr lprcMonitor, IntPtr lparam)
            {
                Monitors.Add(new Monitor(monitor, hdc));
                return true;
            }
        }
    }
}
