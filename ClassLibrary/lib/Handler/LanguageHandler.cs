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
            HandlerFactory.getLogHandler().debug("LanguageHandler.getCaption() start - parameter key=" + key + "'");
            string result = getValue("Language/Caption/" + key);
            if (string.IsNullOrWhiteSpace(result))
            {
                HandlerFactory.getLogHandler().error("LanguageHandler.getCaption() - invalid parameter key='" + key + "'");
                result = "";
            }
            HandlerFactory.getLogHandler().debug("LanguageHandler.getCaption() end - return value result='" + key + "'");
            return result;
        }
        public string getMessage(string key)
        {
            HandlerFactory.getLogHandler().debug("LanguageHandler.getMessage() start - parameter key=" + key + "'");
            string result = getValue("Language/Message/" + key);
            if (string.IsNullOrWhiteSpace(result))
            {
                HandlerFactory.getLogHandler().error("LanguageHandler.getMessage() - invalid parameter key='" + key + "'");
                result = "";
            }
            HandlerFactory.getLogHandler().debug("LanguageHandler.getMessage() end - return value result='" + key + "'");
            return result;
        }
    }
}
