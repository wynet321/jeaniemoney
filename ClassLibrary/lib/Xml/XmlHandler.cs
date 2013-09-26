using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using System.IO;
using System.Globalization;
using System.Xml;
using System.Xml.Linq;

namespace ClassLibrary.lib
{
    public class XmlHandler
    {
        protected XPathNavigator xPathNavigator;
        protected XmlDocument xmlDocument;
        protected string uri;

        public XmlHandler(String uri)
        {
            this.uri = uri;
            xmlDocument = new XmlDocument();
            xmlDocument.Load(uri);
            xPathNavigator = new XPathDocument(uri).CreateNavigator();
        }
        //Get XML node value from xml string
        protected String getValue(String nodePath)
        {
            string result = string.Empty;
            if (string.IsNullOrWhiteSpace(nodePath))
            {
                System.Console.WriteLine("XmlHandler.getValue() WARN - invalid parameter nodePath='" + nodePath + "'");
                return result;
            }
            try
            {
                result = xmlDocument.SelectSingleNode(nodePath).FirstChild.Value;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("XmlHandler.getValue() ERROR - parameter nodePath='" + nodePath + "'");
                System.Console.WriteLine("Message='" + e.Message + "'");
            }
            return result;
        }
        //Set XML node value from xml string
        public void setValue(String nodePath, String value)
        {
            xmlDocument.SelectSingleNode(nodePath).FirstChild.Value = value;
            xmlDocument.Save(uri);
            xmlDocument.Load(uri);
        }
        //Get XML Attribute value from xml string
        public String getAttribute(String nodePath, String attributeName)
        {
            return xmlDocument.SelectSingleNode(nodePath).Attributes[attributeName].Value;
        }
        //Set XML Attribute value from xml string
        public void setAttribute(String nodePath, String attributeName, String attributeValue)
        {
            xmlDocument.SelectSingleNode(nodePath).Attributes[attributeName].Value = attributeValue;
            xmlDocument.Save(uri);
            xmlDocument.Load(uri);
        }
        public void setNodeName(String nodePath, String nodeName)
        {
            XmlNode node = xmlDocument.SelectSingleNode(nodePath);
            XmlElement xe = xmlDocument.CreateElement(nodeName);
            xe.InnerText = node.InnerText;
            node.ParentNode.ReplaceChild(xe, node);
            xmlDocument.Save(uri);
            xmlDocument.Load(uri);
        }
        public List<String> getElementListByNodePath(String nodePath)
        {
            List<String> elementList = new List<String>();
            if (nodePath == null)
            {
                System.Console.WriteLine("XmlHandler.getElementListByNodePath() WARN - Return empty list");
                return elementList;
            }
            XPathNodeIterator node;
            xPathNavigator.MoveToRoot();
            if (nodePath.Length == 0)
                node = xPathNavigator.SelectChildren(XPathNodeType.Element);
            else
                node = xPathNavigator.SelectSingleNode(nodePath).SelectChildren(XPathNodeType.Element);
            while (node.MoveNext())
            {
                elementList.Add(node.Current.Name);
            }
            return elementList;
        }
        public List<String> getRootElementList()
        {
            return getElementListByNodePath("");
        }
        public int getElementCountByNodePath(String nodePath)
        {
            xPathNavigator.MoveToRoot();
            XPathNodeIterator node = xPathNavigator.SelectSingleNode(nodePath).SelectChildren(XPathNodeType.Element);
            return node.Count;
        }
        public List<String> getAttributeValueListByNodePath(String nodePath, String attributeName)
        {
            List<String> elementList = new List<String>();
            XmlNodeList xmlNodeList = xmlDocument.SelectSingleNode(nodePath).ChildNodes;
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                elementList.Add(xmlNode.Attributes[attributeName].Value);
            }

            return elementList;
        }
        public void addNode(String nodePath, String nodeName, String attributeName)
        {
            XmlNode xmlNode = xmlDocument.CreateNode(XmlNodeType.Element, nodeName, String.Empty);
            if (attributeName.Length > 0)
            {
                xmlNode.Attributes.Append(xmlDocument.CreateAttribute(attributeName));
            }
            xmlDocument.SelectSingleNode(nodePath).AppendChild(xmlNode);
            xmlDocument.Save(uri);

        }
    }
}
