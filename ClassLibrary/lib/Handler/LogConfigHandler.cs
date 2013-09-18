using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.lib.Handler
{
    public class LogConfigHandler : XmlHandler
    {
        public LogConfigHandler()
            : base(System.Environment.CurrentDirectory + "/" + "config.xml")
        {
        }
        public string getString(string key)
        {
            string result = getValue(key);
            if (string.IsNullOrWhiteSpace(result))
            {
                result = "";
            }
            return result;
        }

        public int getInteger(string key)
        {
            string resultString = getValue(key);
            int resultInteger = 0;
            try
            {
                resultInteger = int.Parse(resultString);
            }
            catch (Exception e)
            {
                System.Console.Write(e.Message);
                System.Console.Write(e.StackTrace);
            }
            return resultInteger;
        }

        public short getShort(string key)
        {
            string resultString = getValue(key);
            short resultShort = 0;
            try
            {
                resultShort = short.Parse(resultString);
            }
            catch (Exception e)
            {
                System.Console.Write(e.Message);
                System.Console.Write(e.StackTrace);
            }
            return resultShort;
        }
    }
}
