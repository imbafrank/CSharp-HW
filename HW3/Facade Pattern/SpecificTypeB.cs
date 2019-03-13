using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class SpecificTypeB
    {
        public void FunctionA()
        {
            Console.WriteLine("Fa(B)");
        }

        public void FunctionB()
        {
            Console.WriteLine("Fb(B)");
        }
    }
}
