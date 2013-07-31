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
        public static Dictionary<String, String> dbType;
        static HandlerFactory()
        {
            dbType = new Dictionary<string, string>();
            dbType.Add("DB2", "DB2");
            dbType.Add("SQLSERVER", "SQLSERVER");
            dbType.Add("SQLITE", "SQLITE");
        }
        //DB Handler
        private static IDbHandler dbHandler;
        public static IDbHandler getDbHandler(string dbType, string connectionString)
        {
            if (dbHandler == null)
            {
                //string dbType=getConfigHandler().getDbType();
                switch (dbType)
                {
                    case "SQLSERVER":
                        try
                        {
                            dbHandler = new CSqlServerImpl(connectionString);
                        }
                        catch (Exception e)
                        {
                            getLogHandler().error("can't open db connection");
                            throw e;
                        }
                        break;
                    case "DB2": break;
                }
            }
            return dbHandler;
        }

        //public static IDbHandler getDbHandler()
        //{
        //    if (dbHandler == null)
        //    {
        //        string dbType=getConfigHandler().getValue("")
        //        switch (dbType)
        //        {
        //            case "SQLSERVER":
        //                try
        //                {
        //                    dbHandler = new CSqlServerImpl(connectionString);
        //                }
        //                catch (Exception e)
        //                {
        //                    getLogHandler().error("can't open db connection");
        //                    throw e;
        //                }
        //                break;
        //            case "DB2": break;
        //        }
        //    }
        //    return dbHandler;
        //}

        //Configuration XML Handler
        private static XmlHandler configHandler;
        public static XmlHandler getConfigHandler(string uri)
        {
            if (configHandler == null)
            {
                try
                {
                    configHandler = new XmlHandler(uri);
                }
                catch (Exception e)
                {
                    getLogHandler().error("Can't open config file");
                    throw e;
                }
            }
            return configHandler;
        }



        public static XmlHandler getConfigHandler()
        {
            if (configHandler == null)
            {
                try
                {
                    configHandler = new ConfigHandler(System.Environment.CurrentDirectory + "/" + "config.xml");
                }
                catch (Exception e)
                {
                    getLogHandler().error("Can't open config file");
                    throw e;
                }
            }
            return configHandler;
        }

        //Language XML Handler
        private static XmlHandler g18nHandler;
        public static XmlHandler getG18NHandler()
        {
            if (g18nHandler == null)
            {
                try
                {
                    g18nHandler = new XmlHandler(System.Environment.CurrentDirectory + "/lang/" + CultureInfo.CurrentCulture.Name + ".xml");
                }
                catch (Exception e)
                {
                    getLogHandler().error("Can't open X18N file");
                    throw e;
                }
            }
            return g18nHandler;
        }

        //Log Handler
        private static LogHandler logHandler;
        public static LogHandler getLogHandler(string logLevelString, short logFileCount, int logFileSize, string logFullPath)
        {
            if (configHandler == null)
                logHandler = new LogHandler(System.Environment.CurrentDirectory + "/money.log");
            else
            {
                if (logHandler == null)
                {
                    try
                    {
                        logHandler = new LogHandler(logLevelString, logFileCount, logFileSize, logFullPath);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
            return logHandler;
        }
    }
}
