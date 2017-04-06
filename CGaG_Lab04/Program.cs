using System;

namespace CGaG_Lab04 {
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( ) {
            using (MainThread mainThread = new MainThread( ))
                mainThread.Run( );
        }
    }
#endif
}
