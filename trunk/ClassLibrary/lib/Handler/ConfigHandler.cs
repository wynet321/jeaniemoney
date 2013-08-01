using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary.lib;
using System.Reflection;

namespace ClassLibrary.lib
{
    public class ConfigHandler : XmlHandler
    {
        public ConfigHandler():base(System.Environment.CurrentDirectory + "/" + "config.xml")
        {
        }
        public string getDbConnectionString()
        {
            return getValue("Configuration/Database/Connectionstring");
        }
        public string getDbType()
        {
            return getValue("Configuration/Database/DbType");
        }
        public string getLogLevel()
        {
            return getValue("Configuration/Log/LogLevel");
        }
        public string getLogFullPath()
        {
            return getValue("Configuration/Log/LogFullPath");
        }
        public int getLogFileSize()
        {
            return int.Parse(getValue("Configuration/Log/LogFileSize"));
        }
        public short getLogFileCount()
        {
            return short.Parse(getValue("Configuration/Log/LogFileCount"));
        }
    }
}
