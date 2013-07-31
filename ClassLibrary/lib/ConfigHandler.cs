using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary.lib;
using System.Reflection;

namespace ClassLibrary.lib
{
    public sealed class ConfigHandler : XmlHandler
    {
        private string productName;
        private string profileName;
        public ConfigHandler(string xmlFileFullName)
            : base(xmlFileFullName)
        {
            string fullName = Assembly.GetExecutingAssembly().FullName;
            this.productName = fullName.Substring(0, fullName.IndexOf(","));
        }
        public ConfigHandler(string xmlFileFullName, string profileName)
            : base(xmlFileFullName)
        {
            string fullName = Assembly.GetExecutingAssembly().FullName;
            this.productName = fullName.Substring(0, fullName.IndexOf(","));
            this.profileName = profileName;
        }
        public List<string> getProfiles()
        {
            return getElementListByNodePath(productName);
        }
        public void addProfile(string profileName)
        {
            addNode(productName + "/", profileName, null);
            this.profileName = profileName;
        }
        public void modifyProfileName(string originalProfilename, string newProfileName)
        {
            setNodeName(productName + "/" + originalProfilename, newProfileName);
        }
        public string getDbConnectionString()
        {
            return getValue(productName + "/"+profileName+"/Database/Connectionstring");
        }
        
        public void setDbConnectionString(string connectionString)
        {
            setValue(productName +"/" + profileName + "/Database/Connectionstring", connectionString);
        }
        public string getDbType()
        {
            return getValue(productName + "/" + profileName + "/Database/DbType");
        }
        public void setDbType(string dbType)
        {
            setValue(productName + "/" + profileName + "/Database/DbType", dbType);
        }
        public string getServerName()
        {
            return getValue(productName + "/" + profileName + "/Database/ServerName");
        }
        public void setServerName(string serverName)
        {
            setValue(productName + "/" + profileName + "/Database/ServerName", serverName);
        }
        public string getDbName()
        {
            return getValue(productName + "/" + profileName + "/Database/DbName");
        }
        public void setDbName(string dbName)
        {
            setValue(productName + "/" + profileName + "/Database/DbName", dbName);
        }
        public string getDbAdminName()
        {
            return getValue(productName + "/" + profileName + "/Database/DbAdminName");
        }
        public void setDbAdminName(string dbAdminName)
        {
            setValue(productName + "/" + profileName + "/Database/DbAdminName", dbAdminName);
        }
        public string getDbAdminPassword()
        {
            return getValue(productName + "/" + profileName + "/Database/DbAdminPassword");
        }
        public void setDbAdminPassword(string dbAdminPassword)
        {
            setValue(productName + "/" + profileName + "/Database/DbAdminPassword", dbAdminPassword);
        }
        public string getLogLevel()
        {
            return getValue(productName + "/" + profileName + "/Log/LogLevel");
        }
        public string getLogFullPath()
        {
            return getValue(productName + "/" + profileName + "/Log/LogFullPath");
        }
        public int getLogFileSize()
        {
            return int.Parse(getValue(productName + "/" + profileName + "/Log/LogFileSize"));
        }
        public int getLogFileCount()
        {
            return int.Parse(getValue(productName + "/" + profileName + "/Log/LogFileCount"));
        }
    }
}
