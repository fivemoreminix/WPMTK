using System;
using System.Runtime.InteropServices;

namespace WPMTK
{
    public static class NativeMethods
    {
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        #region DLL Includes
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32")]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        [DllImport("user32", SetLastError = true)]
        public  static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("kernel32")]
        public static extern Boolean CloseHandle(IntPtr handle);
        #endregion
    }
}
