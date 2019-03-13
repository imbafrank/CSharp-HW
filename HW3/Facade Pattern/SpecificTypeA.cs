using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class SpecificTypeA
    {
        public void FunctionA()
        {
            Console.WriteLine("Fa(A)");
        }

        public void FunctionB()
        {
            Console.WriteLine("Fb(A)");
        }
    }
}
