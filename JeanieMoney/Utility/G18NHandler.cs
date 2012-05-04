using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace JeanieMoney.Utility
{
    class G18NHandler : XMLHandler
    {
        private static string G18NURI = System.Windows.Forms.Application.StartupPath + "/Lang/" + CultureInfo.CurrentCulture.Name + ".xml";
        //Get Resource XML element value
        public static String GetValue(String NodePath)
        {
            return getValue(G18NURI, NodePath);
        }
        //Get Resource XML element attribute
        public static String GetAttribute(String NodePath, String AttributeName)
        {
            return GetAttribute(G18NURI, NodePath, AttributeName);
        }


    }
}
