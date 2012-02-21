using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using System.IO;
using System.Globalization;

namespace JeanieMoney.Utility
{
    class XMLHelper
    {
        
        private static XPathNavigator getXPathNavigator(String XMLContentOrURI)
        {
            if (XMLContentOrURI.StartsWith("<"))
                return new XPathDocument(new MemoryStream(ASCIIEncoding.Default.GetBytes(XMLContentOrURI))).CreateNavigator();
            else
                return new XPathDocument(XMLContentOrURI).CreateNavigator();
        }
        //Get XML node value from xml string
        public static String GetValue(String XMLContentOrURI, String NodePath)
        {
            return getXPathNavigator(XMLContentOrURI).SelectSingleNode(NodePath).Value;
        }
        //Set XML node value from xml string
        public static void SetValue(String XMLContentOrURI, String NodePath, String Value)
        {
            getXPathNavigator(XMLContentOrURI).SelectSingleNode(NodePath).SetValue(Value);
        }
        //Get XML Attribute value from xml string
        public static String GetAttribute(String XMLContentOrURI, String NodePath, String AttributeName)
        {
            return getXPathNavigator(XMLContentOrURI).SelectSingleNode(NodePath).GetAttribute(AttributeName, "");
        }
        //Set XML Attribute value from xml string
        public static void SetAttribute(String XMLContentOrURI, String NodePath, String AttributeName, String AttributeValue)
        {
            getXPathNavigator(XMLContentOrURI).MoveToAttribute(NodePath, "");
            getXPathNavigator(XMLContentOrURI).SetValue(AttributeValue);
        }
        public static List<String> GetElements(String XMLContentOrURI, String NodePath)
        {
            XPathNodeIterator Node = getXPathNavigator(XMLContentOrURI).SelectSingleNode(NodePath).SelectChildren(XPathNodeType.Element);
            List<String> ElementsList = new List<String>();
            while (Node.MoveNext())
            {
                ElementsList.Add(Node.Current.Name);
            }
            return ElementsList;
        }

    }
}
