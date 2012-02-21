using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace JeanieMoney.Utility
{
    class PropertyHelper : XMLHelper
    {
        private static string ResourceURI = System.Windows.Forms.Application.StartupPath + "/Lang/" + CultureInfo.CurrentCulture.Name + ".xml";
        //Get Resource XML element value
        public static String GetValue(String NodePath)
        {
            return GetValue(ResourceURI, NodePath);
        }
        //Get Resource XML element attribute
        public static String GetAttribute(String NodePath, String AttributeName)
        {
            return GetAttribute(ResourceURI, NodePath, AttributeName);
        }


    }
}
