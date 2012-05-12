using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using System.IO;
using System.Globalization;
using System.Xml;

namespace JeanieMoney.Utility
{
    class XmlHandler
    {
        private static XPathNavigator xPathNavigator;
        private static XmlDocument xmlDocument;
        private static XPathNavigator getXPathNavigator(String XmlContentOrUri)
        {

            if (xPathNavigator == null)
            {
                if (XmlContentOrUri.StartsWith("<"))
                    xPathNavigator = new XPathDocument(new MemoryStream(ASCIIEncoding.Default.GetBytes(XmlContentOrUri))).CreateNavigator();
                else
                    xPathNavigator = new XPathDocument(XmlContentOrUri).CreateNavigator();
            }
            return xPathNavigator;
        }

        private static XmlDocument getXmlDocument(String uri)
        {
            if (xmlDocument == null || xmlDocument.BaseURI != uri)
            {
                xmlDocument = new XmlDocument();
                xmlDocument.Load(uri);
            }
            return xmlDocument;
        }
        //Get XML node value from xml string
        public static String getValue(String uri, String nodePath)
        {
            return getXmlDocument(uri).SelectSingleNode(nodePath).FirstChild.Value;
            //getXPathNavigator(XmlContentOrUri).MoveToRoot();
            //return getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).Value;
        }
        //Set XML node value from xml string
        public static void setValue(String uri, String nodePath, String value)
        {
            
            getXmlDocument(uri).SelectSingleNode(nodePath).FirstChild.Value = value;
            xmlDocument.Save(uri);
            xmlDocument.Load(uri);
            //getXPathNavigator(XmlContentOrUri).MoveToRoot();
            //getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).SetValue(Value);
        }
        //Get XML Attribute value from xml string
        public static String getAttribute(String uri, String nodePath, String attributeName)
        {
            return getXmlDocument(uri).SelectSingleNode(nodePath).Attributes[attributeName].Value;
            //getXPathNavigator(XmlContentOrUri).MoveToRoot();
            //return getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).GetAttribute(attributeName, String.Empty);
        }
        //Set XML Attribute value from xml string
        public static void setAttribute(String uri, String nodePath, String attributeName, String attributeValue)
        {
            getXmlDocument(uri).SelectSingleNode(nodePath).Attributes[attributeName].Value = attributeValue;
            xmlDocument.Save(uri);
            xmlDocument.Load(uri);
        }
        public static List<String> getElementListByNodePath(String XmlContentOrUri, String nodePath)
        {
            getXPathNavigator(XmlContentOrUri).MoveToRoot();
            XPathNodeIterator node = getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).SelectChildren(XPathNodeType.Element);
            List<String> elementList = new List<String>();
            while (node.MoveNext())
            {
                elementList.Add(node.Current.Name);
            }
            return elementList;
        }
        public static int getElementCountByNodePath(String XmlContentOrUri, String nodePath)
        {
            getXPathNavigator(XmlContentOrUri).MoveToRoot();
            XPathNodeIterator node = getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).SelectChildren(XPathNodeType.Element);
            return node.Count;
        }
        public static List<String> getAttributeValueListByNodePath(String uri, String nodePath, String attributeName)
        {
            List<String> elementList = new List<String>();
            XmlNodeList xmlNodeList = getXmlDocument(uri).SelectSingleNode(nodePath).ChildNodes;
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                elementList.Add(xmlNode.Attributes[attributeName].Value);
            }
            //getXPathNavigator(XmlContentOrUri).MoveToRoot();
            //XPathNodeIterator node = getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).SelectChildren(XPathNodeType.Element);
            //List<String> elementList = new List<String>();
            //while (node.MoveNext())
            //{
            //    elementList.Add(node.Current.GetAttribute(attributeName, String.Empty));
            //}
            return elementList;
        }
        public static void addNode(String uri, String nodePath, String nodeName, String attributeName)
        {
            XmlNode xmlNode = getXmlDocument(uri).CreateNode(XmlNodeType.Element, nodeName, String.Empty);
            if (attributeName.Length > 0)
            {
                xmlNode.Attributes.Append(xmlDocument.CreateAttribute(attributeName));
               // xmlNode.Attributes[attributeName].Value = attributeValue;
            }
            xmlDocument.SelectSingleNode(nodePath).AppendChild(xmlNode);
            xmlDocument.Save(uri);
            //getXPathNavigator(XmlContentOrUri).MoveToRoot();
            //getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath).AppendChildElement(String.Empty, nodeName, String.Empty, String.Empty);
            //if (attributeName.Length > 0)
            //    getXPathNavigator(XmlContentOrUri).SelectSingleNode(nodePath + "/" + nodeName).CreateAttribute(String.Empty, attributeName, String.Empty, String.Empty);
        }
    }
}
