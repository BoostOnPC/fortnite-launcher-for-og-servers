using System;   
using System.Runtime.InteropServices;

namespace tetstentfrylauncher
{
    public static class Program
    {
        [System.Runtime.InteropServices.DllImport()]
        public static extern bool BlockInput(bool fBlock);

    
        [DllImport(, SetLastError = true)]
        private static extern IntPtr GetConsoleProcessList(IntPtr[] lpprocess, uint nSize);
        private static extern IntPtr GetConsoleWindow();

        [DllImport("")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0;
      

        [STAThread]
        public static void Main()
        {
         
            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Login());
             

           
        }
    }
}
