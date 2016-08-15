using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Rainbow.Shell.Utility
{
    public static class WindowHelper
    {
        public static bool IsFullScreen { get; private set; }
        private static WindowState _WindowState;
        private static WindowStyle _WindowStyle;
        private static ResizeMode _ResizeMode;
        private static Rect _WindowRect;

        public static void FullScreen(this Window window)
        {
            if (IsFullScreen)
                return;
            StoreWindowState(window);
            var monitor = Monitor.GetCurrentMonitor(window);
            window.WindowState = WindowState.Normal;
            window.WindowStyle = WindowStyle.None;
            window.ResizeMode = ResizeMode.NoResize;
            window.Topmost = true;
            window.Left = monitor.Bounds.Location.X;
            window.Top = monitor.Bounds.Location.Y;
            window.Width = monitor.Bounds.Size.Width; //SystemParameters.PrimaryScreenWidth
            window.Height = monitor.Bounds.Size.Height; //SystemParameters.PrimaryScreenHeight
            IsFullScreen = true;
        }
        public static void ExitFullScreen(this Window window)
        {
            if (!IsFullScreen)
                return;
            window.WindowState = _WindowState;
            window.WindowStyle = _WindowStyle;
            window.ResizeMode = _ResizeMode;
            window.Topmost = false;
            window.Left = _WindowRect.Location.X;
            window.Top = _WindowRect.Location.Y;
            window.Width = _WindowRect.Size.Width;
            window.Height = _WindowRect.Size.Height;
            IsFullScreen = false;
        }
        private static void StoreWindowState(Window window)
        {
            _WindowState = window.WindowState;
            _WindowStyle = window.WindowStyle;
            _ResizeMode = window.ResizeMode;
            _WindowRect = new Rect();
            _WindowRect.Location = new Point() { X = window.Left, Y = window.Top };
            _WindowRect.Size = new Size() { Width = window.Width, Height = window.Height };
        }
    }
}
