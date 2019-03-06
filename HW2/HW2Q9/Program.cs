using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = 100;
            int[] prime = new int[range+1];

            for (int i = 2; i <= Math.Sqrt(range); i++)
            {
                for (int k= 1; k <= range; k++)
                    if (prime[k] == 0 && (k % i == 0 && k != i))
                    {
                        prime[k] = 1;
                    }
            }

            Console.WriteLine("Below are prime nubmers ranging from 2 to " + range +":");

            for (int j = 2; j <= range; j++)
                if (prime[j] == 0)
                    Console.WriteLine(j);

        }
    }
}
