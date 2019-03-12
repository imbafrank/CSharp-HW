using System;
using System.Reflection;
using System.Xml;

namespace Factory_Method
{
    public class XmlManipulate
    {
        public static Object getXmlName()
        {
            try
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"..\..\config.xml");
                XmlNode rootNode = Doc.SelectSingleNode("config");
                String xmlName = rootNode.ChildNodes[0].InnerText;
                Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
                //object obj = assembly.CreateInstance("Factory_Method.SpecificTypeA");
                
                Type type = Type.GetType("Factory_Method.Type"+xmlName+"Factory");
                object obj = Activator.CreateInstance(type, true);
                
                return obj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
