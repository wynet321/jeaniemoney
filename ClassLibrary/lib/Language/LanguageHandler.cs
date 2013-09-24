using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ClassLibrary.lib.Handler
{
    public class LanguageHandler : XmlHandler
    {
        public LanguageHandler()
            : base(System.Environment.CurrentDirectory + "/lang/" + CultureInfo.CurrentCulture.Name + ".xml")
        {
        }
        public string getCaption(string key)
        {
            HandlerFactory.getLogHandler().append("LanguageHandler.getCaption() start - parameter key='" + key + "'", Level.DEBUG, Category.LIB);
            string result = getValue("Language/Caption/" + key);
            if (string.IsNullOrWhiteSpace(result))
            {
                HandlerFactory.getLogHandler().append("LanguageHandler.getCaption() - invalid parameter key='" + key + "'", Level.ERROR, Category.LIB);
                result = "";
            }
            HandlerFactory.getLogHandler().append("LanguageHandler.getCaption() end - return value result='" + result + "'", Level.DEBUG, Category.LIB);
            return result;
        }
        public string getMessage(string key)
        {
            HandlerFactory.getLogHandler().append("LanguageHandler.getMessage() start - parameter key='" + key + "'", Level.DEBUG, Category.LIB);
            string result = getValue("Language/Message/" + key);
            if (string.IsNullOrWhiteSpace(result))
            {
                HandlerFactory.getLogHandler().append("LanguageHandler.getMessage() - invalid parameter key='" + key + "'", Level.ERROR, Category.LIB);
                result = "";
            }
            HandlerFactory.getLogHandler().append("LanguageHandler.getMessage() end - return value result='" + result + "'", Level.DEBUG, Category.LIB);
            return result;
        }
    }
}
