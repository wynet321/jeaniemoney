using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Utility
{
    class ConfigHandler : XMLHandler
    {
        private static readonly string CONFIGURI = System.Windows.Forms.Application.StartupPath + "/config.xml";
        public static String getServerName(String profileName)
        {
            return getValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/ServerName");
        }
        public static void setServerName(String profileName, String serverName)
        {
            setValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/ServerName", serverName);
        }

        public static String getDbName(String profileName)
        {
            return getValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/DbName");
        }
        public static void setDbName(String profileName, String dbName)
        {
            setValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/DbName", dbName);
        }
        public static String getDbAdminName(String profileName)
        {
            return getValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/DbAdminName");
        }
        public static void setDbAdminName(String profileName, String dbAdminName)
        {
            setValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/DbAdminName", dbAdminName);
        }
        public static String getDbAdminPassword(String profileName)
        {
            return getValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/DbAdminPassword");
        }
        public static void setDbAdminPassword(String profileName, String dbAdminPassword)
        {
            setValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/DbAdminPassword", dbAdminPassword);
        }
        public static String getDbType(String profileName)
        {
            return getValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/DbType");
        }
        public static void setDbType(String profileName, String dbType)
        {
            setValue(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']/DbType", dbType);
        }

        public static void addProfile(String profileName)
        {
            addNode(CONFIGURI, "JeanieMoney", "Profile", "Name");
            addNode(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']", "ServerName", String.Empty);
            addNode(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']", "DbName", String.Empty);
            addNode(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']", "DbType", String.Empty);
            addNode(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']", "DbAdminName", String.Empty);
            addNode(CONFIGURI, "JeanieMoney/Profile[@Name='" + profileName + "']", "DbAdminPassword", String.Empty);
        }
        public static List<String> getProfileList()
        {
            return getAttributeValueListByNodePath(CONFIGURI, "JeanieMoney", "Name");
        }
        public static void reviseProfile(String OriginalProfileName, String newProfileName)
        {
            setAttribute(CONFIGURI, "JeanieMoney/Profile[@Name='" + OriginalProfileName + "']","Name", newProfileName);
        }
    }
}
