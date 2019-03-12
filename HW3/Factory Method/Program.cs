using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        {
            try
            {
                //String xmlName = 
                IFactory factory = (IFactory)XmlManipulate.getXmlName();
                IType typeN = factory.Generation();
                typeN.Function();
                //IType typeN = TypeFactory.Generation(xmlName);
                //typeN.Function();
            }
             
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
