using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            int oid;
            if (int.TryParse(Console.ReadLine(), out oid))
            {
                Console.WriteLine("Hello World!");

                os.AddOrder(oid, "hi");
                Console.WriteLine("{0}", os.GetByCname("hi")[0]);

            }


            //Console.ReadKey();

        }
    }
}
