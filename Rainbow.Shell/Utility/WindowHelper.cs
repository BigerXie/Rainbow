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
        private static double _LeftDistance;
        private static double _TopDistance;
        private static double _WindowHeight;
        private static double _WindowWidth;

        public static void FullScreen(this Window window)
        {
            if (IsFullScreen)
                return;
            StoreWindowState(window);
            window.WindowState = WindowState.Normal;
            window.WindowStyle = WindowStyle.None;
            window.ResizeMode = ResizeMode.NoResize;
            window.Topmost = true;
            window.Left = 0.0;
            window.Top = 0.0;
            window.Width = SystemParameters.PrimaryScreenWidth;
            window.Height = SystemParameters.PrimaryScreenHeight;
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
            window.Left = _LeftDistance;
            window.Top = _TopDistance;
            window.Width = _WindowWidth;
            window.Height = _WindowHeight;
            IsFullScreen = false;
        }
        private static void StoreWindowState(Window window)
        {
            _WindowState = window.WindowState;
            _WindowStyle = window.WindowStyle;
            _ResizeMode = window.ResizeMode;
            _LeftDistance = window.Left;
            _TopDistance = window.Top;
            _WindowHeight = window.Height;
            _WindowWidth = window.Width;
        }
    }
}
