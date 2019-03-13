using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralTypeFacade gtf = new GeneralTypeFacade();
            gtf.FunctionA();
            Console.WriteLine("-----------------------");
            gtf.FunctionB();
        }
    }
}
