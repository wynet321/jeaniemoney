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
                    string dbType = getConfigHandler().getString("Configuration/Database/Type");
                    string connectionString = getConfigHandler().getString("Configuration/Database/ConnectionString");
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

        //Log Handler
        private static LogHandler logHandler;
        public static LogHandler getLogHandler()
        {
            if (logHandler == null)
            {
                if (configHandler == null)
                {
                    logHandler = new LogHandler();
                    logHandler.error("Can't open config file");
                }
                else
                {
                    try
                    {
                        string logLevelString = getConfigHandler().getString("Configuration/Log/Level");
                        short logFileCount = getConfigHandler().getShort("Configuration/Log/FileCount");
                        int logFileSize = getConfigHandler().getInteger("Configuration/Log/FileSize");
                        string logFullPath = getConfigHandler().getString("Configuration/Log/FileName");
                        logHandler = new LogHandler(logLevelString, logFileCount, logFileSize, logFullPath);
                    }
                    catch (Exception e)
                    {
                        logHandler = new LogHandler();
                        logHandler.error(e.Message);
                    }
                }
            }
            return logHandler;
        }

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

    }
}
