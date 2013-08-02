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
            return getValue("Configuration/Database/ConnectionString");
        }
        public string getDbType()
        {
            return getValue("Configuration/Database/Type");
        }
        public string getLogLevel()
        {
            return getValue("Configuration/Log/Level");
        }
        public string getLogFullPath()
        {
            return getValue("Configuration/Log/FileName");
        }
        public int getLogFileSize()
        {
            return int.Parse(getValue("Configuration/Log/FileSize"));
        }
        public short getLogFileCount()
        {
            return short.Parse(getValue("Configuration/Log/FileCount"));
        }
    }
}
