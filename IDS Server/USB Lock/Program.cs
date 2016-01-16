using System;
using System.Windows.Forms;

namespace USB_Policy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        //global variables
        public static string strPwdFilePath = 
            Environment.GetEnvironmentVariable("SystemRoot");
        public static bool isPwdEnabled = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}