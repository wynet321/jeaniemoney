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
        private static DbHandler dbHandler;
        public static DbHandler getDbHandler()
        {
            if (dbHandler == null)
            {
                try
                {
                    string dbType = getConfigHandler().getString("Configuration/Database/Type");
                    HandlerFactory.getLogHandler().append("HandlerFactory.getDbHandler() - dbType='" + dbType + "'", Level.DEBUG, Category.LIB);
                    string connectionString = getConfigHandler().getString("Configuration/Database/ConnectionString");
                    HandlerFactory.getLogHandler().append("HandlerFactory.getDbHandler() - connectionString='" + connectionString + "'", Level.DEBUG, Category.LIB);
                    switch (dbType)
                    {
                        case "SQLSERVER":
                            dbHandler = new SqlServerHandler(connectionString);
                            break;
                        case "DB2": break;
                    }
                }
                catch (Exception e)
                {
                    HandlerFactory.getLogHandler().append("HandlerFactory.getDbHandler() - Failed to create DB connection. Message:'" + e.Message + "'", Level.ERROR, Category.LIB);
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
                    HandlerFactory.getLogHandler().append("HandlerFactory.getConfigHandler() - Failed to initiate ConfigHandler. Message:'" + e.Message + "'", Level.ERROR, Category.LIB);
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

        private static LogHandler logHandler;
        public static LogHandler getLogHandler()
        {
            if (logHandler == null)
                try
                {
                    logHandler = new LogHandler();
                }
                catch (Exception e)
                {
                    System.Console.Write(e.Message);
                    System.Console.Write(e.StackTrace);
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
                    HandlerFactory.getLogHandler().append("HandlerFactory.getLanguageHandler() - Failed to load language XML. Message:'" + e.Message + "'", Level.ERROR, Category.LIB);
                }
            }
            return languageHandler;
        }
    }

}
