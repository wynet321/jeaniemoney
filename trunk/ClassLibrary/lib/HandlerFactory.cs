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
            getLogHandler().debug("HandlerFactory.getDbHandler() - start");
            if (dbHandler == null)
            {
                try
                {
                    string dbType = getConfigHandler().getString("Configuration/Database/Type");
                    getLogHandler().debug("HandlerFactory.getDbHandler() - dbType='" + dbType + "'");
                    string connectionString = getConfigHandler().getString("Configuration/Database/ConnectionString");
                    getLogHandler().debug("HandlerFactory.getDbHandler() - connectionString='" + connectionString + "'");
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
                    getLogHandler().error("HandlerFactory.getDbHandler() - Failed to create DB connection. Message:'" + e.Message + "'");
                }
            }
            getLogHandler().debug("HandlerFactory.getDbHandler() - end");
            return dbHandler;
        }

        //Configuration XML Handler
        private static ConfigHandler configHandler;
        public static ConfigHandler getConfigHandler()
        {
            getLogHandler().debug("HandlerFactory.getConfigHandler() - start");
            if (configHandler == null)
            {
                try
                {
                    configHandler = new ConfigHandler();
                }
                catch (Exception e)
                {
                    getLogHandler().error("HandlerFactory.getConfigHandler() - Failed to load Configuration XML. Message:'" + e.Message + "'");
                }
            }
            getLogHandler().debug("HandlerFactory.getConfigHandler() - end");
            return configHandler;
        }

        //Log Handler
        private static LogHandler logHandler;
        public static LogHandler getLogHandler()
        {
            if (logHandler == null)
            {
                logHandler = new LogHandler();
                getLogHandler().debug("HandlerFactory.getLogHandler() - start");
                try
                {
                    string logLevelString = getConfigHandler().getString("Configuration/Log/Level");
                    getLogHandler().debug("HandlerFactory.getLogHandler() - logLevelString='"+logLevelString+"'");
                    short logFileCount = getConfigHandler().getShort("Configuration/Log/FileCount");
                    getLogHandler().debug("HandlerFactory.getLogHandler() - logFileCount='" + logFileCount + "'");
                    int logFileSize = getConfigHandler().getInteger("Configuration/Log/FileSize");
                    getLogHandler().debug("HandlerFactory.getLogHandler() - logFileSize='" + logFileSize + "'");
                    string logFullPath = getConfigHandler().getString("Configuration/Log/FileName");
                    getLogHandler().debug("HandlerFactory.getLogHandler() - logFullPath='" + logFullPath + "'");
                    logHandler = new LogHandler(logLevelString, logFileCount, logFileSize, logFullPath);
                }
                catch (Exception e)
                {
                    logHandler = new LogHandler();
                    logHandler.error("HandlerFactory.LogHandler() - Failed to get logger information from Configuration XML. Message:'" + e.Message + "'");
                }
                getLogHandler().debug("HandlerFactory.getLogHandler() - end");
            }
            return logHandler;
        }

        private static LanguageHandler languageHandler;
        public static LanguageHandler getLanguageHandler()
        {
            getLogHandler().debug("HandlerFactory.getLanguageHandler() - start");
            if (languageHandler == null)
            {
                try
                {
                    languageHandler = new LanguageHandler();
                }
                catch (Exception e)
                {
                    getLogHandler().error("HandlerFactory.getLanguageHandler() - Failed to load language XML. Message:'" + e.Message + "'");
                }
            }
            getLogHandler().debug("HandlerFactory.getLanguageHandler() - end");
            return languageHandler;
        }
        private static Entry logger;
        public static Entry getLogger()
        {
            if (logger == null)
            {
                logger = new Entry();

            }
            return logger;
        }
    }
   
}
