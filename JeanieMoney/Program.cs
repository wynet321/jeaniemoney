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
            Config.getConfig().path = HandlerFactory.getLogConfigHandler().getString("/Configuration/Log/FileName");
            Config.getConfig().fileCount = HandlerFactory.getLogConfigHandler().getInteger("/Configuration/Log/FileCount");
            Config.getConfig().fileSize = HandlerFactory.getLogConfigHandler().getInteger("/Configuration/Log/FileSize");
            Config.getConfig().level = (Level)Enum.Parse(typeof(Level), HandlerFactory.getLogConfigHandler().getString("/Configuration/Log/Level"), true);
            Config.getConfig().categoryList = HandlerFactory.getLogConfigHandler().getElementListByNodePath("/Configuration/Log/Category").ConvertAll(new Converter<string, Category>(Config.getConfig().stringToCategory));
            Logger.getLogger().addHandler(new FileHandler(Config.getConfig()));
            Logger.getLogger().addHandler(new ConsoleHandler(Config.getConfig()));

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);

            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                Main main = new Main();
                Application.Run(main);
            }
        }
        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            Logger.getLogger().flush();
        }
    }
}
