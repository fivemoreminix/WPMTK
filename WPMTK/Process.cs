using System;

namespace WPMTK
{
    public class Process : IDisposable
    {
        public static Exception ProcessNotFoundException = new Exception(
            "Could not find the process specified. " +
            "Please reference the process by it's window title exactly as it appears. " +
            "E.x. \"Mount&Blade\".");
        public VAMemory memory;
        private IntPtr hWnd;

        private string windowTitle;
        private bool disposed = false;

        public Process(string window_title)
        {
            this.windowTitle = window_title;
        }

        /// <summary>
        /// Retrieve the window title of the process.
        /// </summary>
        /// <returns></returns>
        public string GetWindowTitle()
        {
            return windowTitle;
        }

        #region hWnd & VAMemory
        public void Attach()
        {
            if (!SethWnd(windowTitle)) // true if succeeded
            {
                throw ProcessNotFoundException;
            }
            memory = new VAMemory(windowTitle);
        }
        
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

        /// <summary>
        /// Changes this object to attach to an entirely different process.
        /// </summary>
        /// <param name="window_title">Name of process to attach to.</param>
        /// <returns>True if no errors, false if failed to locate new process: returns to same process.</returns>
        public void ChangeProcess(string window_title)
        {
            if (SethWnd(window_title)) // if false, failed
            {
                memory = new VAMemory(window_title);
                windowTitle = window_title;
            }
            else
            {
                throw ProcessNotFoundException;
            }
        }
        #endregion

        #region Disposal
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                // managed resources to dispose
                if (disposing)
                {
                    // none
                }
                NativeMethods.CloseHandle(hWnd);
                hWnd = IntPtr.Zero;
                disposed = true;
            }
        }

        ~Process()
        {
            Dispose(false);
        }
        #endregion
    }
}
