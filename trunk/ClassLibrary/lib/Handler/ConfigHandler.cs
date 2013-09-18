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
        public ConfigHandler()
            : base(System.Environment.CurrentDirectory + "/" + "config.xml")
        {
        }
        public string getString(string key)
        {
            Logger.getLogger().append("ConfigHandler.getString() start - parameter key=" + key + "'", Level.DEBUG, Category.LIB);
            string result = getValue(key);
            if (string.IsNullOrWhiteSpace(result))
            {
                Logger.getLogger().append("ConfigHandler.getString() - invalid parameter key='" + key + "'", Level.ERROR,Category.LIB);
                result = "";
            }
            Logger.getLogger().append("ConfigHandler.getString() end - return value result='" + result + "'", Level.DEBUG, Category.LIB);
            return result;
        }

        public int getInteger(string key)
        {
            Logger.getLogger().append("ConfigHandler.getInteger() start - parameter key=" + key + "'", Level.DEBUG, Category.LIB);
            string resultString = getValue(key);
            int resultInteger = 0;
            try
            {
                resultInteger = int.Parse(resultString);
            }
            catch (Exception e)
            {
                Logger.getLogger().append("ConfigHandler.getInteger() - parameter key='" + key + "', Message='" + e.Message + "'", Level.ERROR, Category.LIB);
            }
            Logger.getLogger().append("ConfigHandler.getInteger() end - return value resultInteger=" + resultInteger, Level.DEBUG, Category.LIB);
            return resultInteger;
        }

        public short getShort(string key)
        {
            Logger.getLogger().append("ConfigHandler.getShort() start - parameter key=" + key + "'", Level.DEBUG, Category.LIB);
            string resultString = getValue(key);
            short resultShort = 0;
            try
            {
                resultShort = short.Parse(resultString);
            }
            catch (Exception e)
            {
                Logger.getLogger().append("ConfigHandler.getShort() - parameter key='" + key + "', Message='" + e.Message + "'", Level.ERROR, Category.LIB);
            }
            Logger.getLogger().append("ConfigHandler.getShort() end - return value resultShort=" + resultShort, Level.DEBUG, Category.LIB);
            return resultShort;
        }
    }
}
