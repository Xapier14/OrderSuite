using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OrderSuite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Check if another instance of the same application is already running.
            if (Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Length > 1)
            {
                //Display a messagebox and exit environment with code 400.
                MessageBox.Show("Another instance of the application is already running.\nOnly one instance should be running as it can cause unwanted conflicts for the server.", "Application Error (400)", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Environment.Exit(400);
            }
            //Run Start Window
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
