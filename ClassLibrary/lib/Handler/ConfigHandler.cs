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
        public string getString(string key)
        {
            return getValue(key);
        }

        public int getInteger(string key)
        {
            return int.Parse(getValue(key));
        }

        public short getShort(string key)
        {
            return short.Parse(getValue(key));
        }
    }
}
