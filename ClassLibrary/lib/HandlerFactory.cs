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
            Logger.getLogger().append("HandlerFactory.getDbHandler() - start", Level.DEBUG, Category.LIB);
            if (dbHandler == null)
            {
                try
                {
                    string dbType = getConfigHandler().getString("Configuration/Database/Type");
                    Logger.getLogger().append("HandlerFactory.getDbHandler() - dbType='" + dbType + "'", Level.DEBUG, Category.LIB);
                    string connectionString = getConfigHandler().getString("Configuration/Database/ConnectionString");
                    Logger.getLogger().append("HandlerFactory.getDbHandler() - connectionString='" + connectionString + "'", Level.DEBUG, Category.LIB);
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
                    Logger.getLogger().append("HandlerFactory.getDbHandler() - Failed to create DB connection. Message:'" + e.Message + "'", Level.ERROR, Category.LIB);
                }
            }
            Logger.getLogger().append("HandlerFactory.getDbHandler() - end", Level.DEBUG, Category.LIB);
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
                    Logger.getLogger().append("HandlerFactory.getConfigHandler() - Failed to initiate ConfigHandler. Message:'"+e.Message+"'", Level.ERROR, Category.LIB);
                }
            }
            return configHandler;
        }

        private static LogConfigHandler logConfigHandler;
        public static LogConfigHandler getLogConfigHandler()
        {
            if (logConfigHandler == null)
            {
                try
                {
                    logConfigHandler = new LogConfigHandler();
                }
                catch (Exception e)
                {
                    System.Console.Write(e.Message);
                    System.Console.Write(e.StackTrace);
                }
            }
            return logConfigHandler;
        }

        //Log Handler
        //private static LogHandler logHandler;
        //public static LogHandler Logger.getLogger()
        //{
        //    if (logHandler == null)
        //    {
        //        logHandler = new LogHandler();
        //        Logger.getLogger().debug("Logger.getLogger() - start");
        //        try
        //        {
        //            string logLevelString = getConfigHandler().getString("Configuration/Log/Level");
        //            Logger.getLogger().debug("Logger.getLogger() - logLevelString='"+logLevelString+"'");
        //            short logFileCount = getConfigHandler().getShort("Configuration/Log/FileCount");
        //            Logger.getLogger().debug("Logger.getLogger() - logFileCount='" + logFileCount + "'");
        //            int logFileSize = getConfigHandler().getInteger("Configuration/Log/FileSize");
        //            Logger.getLogger().debug("Logger.getLogger() - logFileSize='" + logFileSize + "'");
        //            string logFullPath = getConfigHandler().getString("Configuration/Log/FileName");
        //            Logger.getLogger().debug("Logger.getLogger() - logFullPath='" + logFullPath + "'");
        //            logHandler = new LogHandler(logLevelString, logFileCount, logFileSize, logFullPath);
        //        }
        //        catch (Exception e)
        //        {
        //            logHandler = new LogHandler();
        //            logHandler.error("HandlerFactory.LogHandler() - Failed to get logger information from Configuration XML. Message:'" + e.Message + "'");
        //        }
        //        Logger.getLogger().debug("Logger.getLogger() - end");
        //    }
        //    return logHandler;
        //}

        private static LanguageHandler languageHandler;
        public static LanguageHandler getLanguageHandler()
        {
            Logger.getLogger().append("HandlerFactory.getLanguageHandler() - start", Level.DEBUG, Category.LIB);
            if (languageHandler == null)
            {
                try
                {
                    languageHandler = new LanguageHandler();
                }
                catch (Exception e)
                {
                    Logger.getLogger().append("HandlerFactory.getLanguageHandler() - Failed to load language XML. Message:'" + e.Message + "'", Level.ERROR, Category.LIB);
                }
            }
            Logger.getLogger().append("HandlerFactory.getLanguageHandler() - end", Level.DEBUG, Category.LIB);
            return languageHandler;
        }
    }
   
}
