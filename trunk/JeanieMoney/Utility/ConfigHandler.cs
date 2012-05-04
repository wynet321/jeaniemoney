using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Utility
{
    class ConfigHandler : XMLHandler
    {
        private static readonly string CONFIGURI = System.Windows.Forms.Application.StartupPath + "/config.xml";
        //Get Resource XML element value
        public static String getValue(String nodePath)
        {
            return getValue(CONFIGURI, nodePath);
        }
        //Get Resource XML element attribute
        public static String getAttribute(String nodePath, String attributeName)
        {
            return GetAttribute(CONFIGURI, nodePath, attributeName);
        }
        //Set Resource XML element value
        public static void setValue(String nodePath, String value)
        {
            setValue(CONFIGURI, nodePath, value);
        }
        //Set Resource XML element attribute
        public static void setAttribute(String nodePath, String attributeName,String attributeValue)
        {
            SetAttribute(CONFIGURI, nodePath, attributeName,attributeValue);
        }
    }
}
