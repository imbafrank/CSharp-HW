using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class TypeBFactory:IFactory
    {
        public IType Generation() 
        {
            Console.WriteLine("B is generated");
            return new SpecificTypeB();
        }
    }
}
