using System;
using System.Runtime.InteropServices;

namespace WPMTK
{
    /// <summary>
    /// Contains functions and definitions imported from Windows DLLs.
    /// We don't expect you to use these, but you can if you need to.
    /// </summary>
    public static class NativeMethods
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        #region DLL Includes
        [DllImport("user32")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32", SetLastError = true)]
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
