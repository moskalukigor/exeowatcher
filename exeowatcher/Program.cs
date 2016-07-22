using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exeowatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Start start = new Start();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3);
            start.Show();
            while(end > DateTime.Now)
            {
                Application.DoEvents();
            }
            start.Close();
            start.Dispose();

            Application.Run(new MainForm());
        }
    }
}
