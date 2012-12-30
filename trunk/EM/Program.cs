using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           // Application.ApplicationExit += new EventHandler(EM);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EM EM = new EM();
            Application.Run(EM);
        }
    }
}
