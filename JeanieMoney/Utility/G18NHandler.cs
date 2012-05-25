using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace JeanieMoney.Utility
{
    class G18NHandler : XmlHandler
    {
        private static string G18NURI = System.Windows.Forms.Application.StartupPath + "/Lang/" + CultureInfo.CurrentCulture.Name + ".xml";
        //Get Resource XML element value
        public static String getValue(String NodePath)
        {
            return getValue(G18NURI, NodePath);
        }
        //Get Resource XML element attribute
        public static String getAttribute(String NodePath, String AttributeName)
        {
            return getAttribute(G18NURI, NodePath, AttributeName);
        }


    }
}
