using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary.lib.Handler;
using ClassLibrary.lib.DBImpl;
using System.Globalization;

namespace ClassLibrary.lib
{
    public class HandlerFactory
    {

        static HandlerFactory()
        {
            configHandler = getConfigHandler();
        }
        //DB Handler
        private static IDbHandler dbHandler;
        public static IDbHandler getDbHandler()
        {
            if (dbHandler == null)
            {
                try
                {
                    string dbType = getConfigHandler().getDbType();
                    string connectionString = getConfigHandler().getDbConnectionString();
                    switch (dbType)
                    {
                        case "SQLSERVER":
                            dbHandler = new CSqlServerImpl(connectionString);
                            break;
                        case "DB2": break;
                    }
                }
                catch (Exception e)
                {
                    getLogHandler().error(e.Message);
                }
            }
            return dbHandler;
        }

        //Configuration XML Handler
        private static ConfigHandler configHandler;
        public static ConfigHandler getConfigHandler()
        {
            if (configHandler == null)
            {
                try
                {
                    configHandler = new ConfigHandler();
                }
                catch (Exception e)
                {
                    getLogHandler().error(e.Message);
                }
            }
            return configHandler;
        }

        //Language XML Handler
        //private static XmlHandler g18nHandler;
        //public static XmlHandler getG18NHandler()
        //{
        //    if (g18nHandler == null)
        //    {
        //        try
        //        {
        //            g18nHandler = new XmlHandler(System.Environment.CurrentDirectory + "/lang/" + CultureInfo.CurrentCulture.Name + ".xml");
        //        }
        //        catch (Exception e)
        //        {
        //            getLogHandler().error("Can't open X18N file");
        //            throw e;
        //        }
        //    }
        //    return g18nHandler;
        //}

        private static LanguageHandler languageHandler;
        public static LanguageHandler getLanguageHandler()
        {
            if (languageHandler == null)
            {
                try
                {
                    languageHandler = new LanguageHandler();
                }
                catch (Exception e)
                {
                    getLogHandler().error(e.Message);
                }
            }
            return languageHandler;
        }

        //Log Handler
        private static LogHandler logHandler;
        public static LogHandler getLogHandler()
        {
            if (logHandler == null)
            {
                try
                {
                    string logLevelString = getConfigHandler().getLogLevel();
                    short logFileCount = getConfigHandler().getLogFileCount();
                    int logFileSize = getConfigHandler().getLogFileSize();
                    string logFullPath = getConfigHandler().getLogFullPath();
                    logHandler = new LogHandler(logLevelString, logFileCount, logFileSize, logFullPath);
                }
                catch (Exception e)
                {
                    logHandler = new LogHandler();
                    logHandler.error(e.Message);
                }
            }
            return logHandler;
        }
    }
}
