using System;
using System.Xml;

namespace Simple_Factory
{
    public class XmlManipulate
    {
        public static String getXmlName()
        {
            try
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"..\..\config.xml");
                XmlNode rootNode = Doc.SelectSingleNode("config");
                String xmlName = rootNode.ChildNodes[0].InnerText;

                return xmlName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
