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
            ConfigInfo.getConfigInfo().path = HandlerFactory.getLogConfigHandler().getString("/Configuration/Log/FileName");
            ConfigInfo.getConfigInfo().fileCount = HandlerFactory.getLogConfigHandler().getInteger("/Configuration/Log/FileCount");
            ConfigInfo.getConfigInfo().fileSize = HandlerFactory.getLogConfigHandler().getInteger("/Configuration/Log/FileSize");
            ConfigInfo.getConfigInfo().level = (Level)Enum.Parse(typeof(Level), HandlerFactory.getLogConfigHandler().getString("/Configuration/Log/Level"), true);
            ConfigInfo.getConfigInfo().categoryList = HandlerFactory.getLogConfigHandler().getElementListByNodePath("/Configuration/Log/Category").ConvertAll(new Converter<string, Category>(ConfigInfo.getConfigInfo().stringToCategory));
            HandlerFactory.getLogHandler().addHandler(new FileHandler(ConfigInfo.getConfigInfo()));
            HandlerFactory.getLogHandler().addHandler(new ConsoleHandler(ConfigInfo.getConfigInfo()));

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
