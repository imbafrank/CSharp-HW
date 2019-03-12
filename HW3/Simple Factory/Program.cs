using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Simple_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String xmlName = XmlManipulate.getXmlName();
                IType typeN = TypeFactory.Generation(xmlName);
                typeN.Function();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
