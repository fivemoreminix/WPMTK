using System;

namespace WPMTK
{
    /// <summary>
    /// A Process object defines the attributes of a running windowed application on your computer.
    /// NOTE: The Process class locates processes on your computer based on the window title you specify in the constructor.
    /// </summary>
    public class Process : IDisposable
    {
        /// <summary>
        /// This exception may occur when you specify a target process that could not be found.
        /// </summary>
        public static Exception ProcessNotFoundException = new Exception(
            "Could not find the process specified. " +
            "Please reference the process by it's window title exactly as it appears. " +
            "E.x. \"Mount&Blade\".");
        /// <summary>
        /// Access to the VAMemory object that directly manages memory addresses.
        /// Use this to do things like: reading and writing the health of the player, reading/writing ammo, etc.
        /// </summary>
        public VAMemory memory;
        private IntPtr hWnd;

        public string WindowTitle { get; private set; }
        private bool disposed = false;
        
        /// <summary>
        /// Initialize a new Process. May return <see cref="ProcessNotFoundException"/> if it could not locate the process specified by its window's title.
        /// </summary>
        /// <param name="window_title"></param>
        public Process(string window_title)
        {
            if (!SethWnd(window_title)) // true if succeeded
            {
                throw ProcessNotFoundException;
            }
            memory = new VAMemory(window_title);
            WindowTitle = window_title;
        }

        #region Getters
        /// <summary>
        /// Uses NativeMethods.GetWindowRect() to retrieve the RECT of the process's main window.
        /// </summary>
        /// <returns>NativeMethods.RECT</returns>
        public NativeMethods.RECT GetWindowRect()
        {
            NativeMethods.RECT rect;
            NativeMethods.GetWindowRect(hWnd, out rect);
            return rect;
        }
        #endregion

        #region hWnd & VAMemory
        private bool SethWnd(string title)
        {
            try
            {
                hWnd = NativeMethods.FindWindow(null, title);
                if (hWnd == null)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Get the HWND that belongs to this process.
        /// </summary>
        /// <returns>IntPtr (hWnd)</returns>
        public IntPtr GethWnd()
        {
            return hWnd;
        }
        #endregion

        #region Disposal
        /// <summary>
        /// When you're done using the Process object, please dispose it. When you dispose, it clears the unused memory.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected unsafe virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                // managed resources to dispose
                if (disposing)
                {
                    // none
                }
                try {
                    NativeMethods.CloseHandle(hWnd);
                } catch {
                    // do nothing, lol
                }
                hWnd = IntPtr.Zero;
                disposed = true;
            }
        }

        /// <summary>
        /// A quick way to dispose the Process object.
        /// <see cref="Dispose"/>
        /// </summary>
        ~Process()
        {
            Dispose(false);
        }
        #endregion
    }
}
