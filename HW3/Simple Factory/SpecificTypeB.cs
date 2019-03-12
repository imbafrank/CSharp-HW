using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    class SpecificTypeB : IType
    {
        public void Function()
        {
            Console.WriteLine("This is B");
        }
    }
}
