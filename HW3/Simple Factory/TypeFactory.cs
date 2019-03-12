using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    class TypeFactory
    {
        public static IType Generation(String xmlName) 
        {
		    if(xmlName.Equals("A"))
		    {
			    Console.WriteLine("A is generated");
			    return new SpecificTypeA();
            }
            else if (xmlName.Equals("B"))
            {
                Console.WriteLine("B is generated");
                return new SpecificTypeB();
            }
            else
		    {
			    throw new Exception("Type unkown");
		    }
        }
    }
}
