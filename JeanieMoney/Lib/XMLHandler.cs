using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using System.IO;
using System.Globalization;

namespace JeanieMoney.Utility
{
    class XMLHandler
    {
        
        private static XPathNavigator getXPathNavigator(String XmlContentOrUri)
        {
            if (XmlContentOrUri.StartsWith("<"))
                return new XPathDocument(new MemoryStream(ASCIIEncoding.Default.GetBytes(XmlContentOrUri))).CreateNavigator();
            else
                return new XPathDocument(XmlContentOrUri).CreateNavigator();
        }
        //Get XML node value from xml string
        public static String getValue(String XmlContentOrUri, String nodePath)
        {
            return getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).Value;
        }
        //Set XML node value from xml string
        public static void setValue(String XmlContentOrUri, String nodePath, String Value)
        {
            getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).SetValue(Value);
        }
        //Get XML Attribute value from xml string
        public static String GetAttribute(String XmlContentOrUri, String nodePath, String attributeName)
        {
            return getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).GetAttribute(attributeName, "");
        }
        //Set XML Attribute value from xml string
        public static void SetAttribute(String XmlContentOrUri, String nodePath, String attributeName, String attributeValue)
        {
            getXPathNavigator(XmlContentOrUri).MoveToAttribute(nodePath, "");
            getXPathNavigator(XmlContentOrUri).SetValue(attributeValue);
        }
        public static List<String> GetElements(String XmlContentOrUri, String nodePath)
        {
            XPathNodeIterator node = getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).SelectChildren(XPathNodeType.Element);
            List<String> elementsList = new List<String>();
            while (node.MoveNext())
            {
                elementsList.Add(node.Current.Name);
            }
            return elementsList;
        }

    }
}
