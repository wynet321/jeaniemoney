using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Forms;
using ClassLibrary.lib.Handler;
using ClassLibrary.lib.DBImpl;
using ClassLibrary;
using ClassLibrary.lib;

namespace JeanieMoney
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

            Application.ApplicationExit+= new EventHandler(CurrentDomain_ProcessExit);
            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                Main main = new Main();
                Application.Run(main);
            }
            HandlerFactory.getLogHandler().flush();
        }
        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            HandlerFactory.getLogHandler().flush();
        }
    }
}
