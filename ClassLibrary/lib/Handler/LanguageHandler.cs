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
            return getValue("Language/Caption/" + key);
        }
        public string getMessage(string key)
        {
            return getValue("Language/Message/" + key);
        }
    }
}
