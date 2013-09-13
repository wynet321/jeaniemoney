using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Forms;
using ClassLibrary.lib.Handler;
using ClassLibrary.lib.DBImpl;
using ClassLibrary;
using ClassLibrary.lib.Logging;
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
            //init log
            Logger logger = new Logger();
            Config logConfig = new Config();
            logConfig.path = HandlerFactory.getConfigHandler().getString("/Configuration/Log/FileName");

            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                Main main = new Main();
                Application.Run(main);
            }
        }
    }
}
