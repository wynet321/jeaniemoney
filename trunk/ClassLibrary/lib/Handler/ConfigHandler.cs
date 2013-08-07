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
            HandlerFactory.getLogHandler().debug("ConfigHandler.getString() start - parameter key=" + key + "'");
            string result = getValue(key);
            if (string.IsNullOrWhiteSpace(result))
            {
                HandlerFactory.getLogHandler().error("ConfigHandler.getString() - invalid parameter key='" + key + "'");
                result = "";
            }
            HandlerFactory.getLogHandler().debug("ConfigHandler.getString() end - return value result='" + result + "'");
            return result;
        }

        public int getInteger(string key)
        {
            HandlerFactory.getLogHandler().debug("ConfigHandler.getInteger() start - parameter key=" + key + "'");
            string resultString = getValue(key);
            int resultInteger = 0;
            try
            {
                resultInteger = int.Parse(resultString);
            }
            catch (Exception e)
            {
                HandlerFactory.getLogHandler().error("ConfigHandler.getInteger() - parameter key='" + key + "', Message='" + e.Message + "'");
            }
            HandlerFactory.getLogHandler().debug("ConfigHandler.getInteger() end - return value resultInteger=" + resultInteger);
            return resultInteger;
        }

        public short getShort(string key)
        {
            HandlerFactory.getLogHandler().debug("ConfigHandler.getShort() start - parameter key=" + key + "'");
            string resultString = getValue(key);
            short resultShort = 0;
            try
            {
                resultShort = short.Parse(resultString);
            }
            catch (Exception e)
            {
                HandlerFactory.getLogHandler().error("ConfigHandler.getShort() - parameter key='" + key + "', Message='" + e.Message + "'");
            }
            HandlerFactory.getLogHandler().debug("ConfigHandler.getShort() end - return value resultShort=" + resultShort);
            return resultShort;
        }
    }
}
