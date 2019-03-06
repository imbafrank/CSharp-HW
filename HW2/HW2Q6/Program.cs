using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (PrimeJudgement())
            {

            }

            return;
        }

        private static bool PrimeJudgement()
        {
            Console.WriteLine("Please enter an positive integer");
            string input = Console.ReadLine();
            int num;
            if (!int.TryParse(input, out num) || num < 1)
            {
                Console.WriteLine("Error input!");
                return false;
            }

            if (!RemainderCheck(num))
            {
                Console.WriteLine("Not a prime.");
            }
            else
            {
                Console.WriteLine("It's a prime.");
            }

            return true;
        }

        private static bool RemainderCheck(int num)
        {
            if (num >= 4)
            {
                int sqrt = (int)Math.Sqrt(num);
                for (int i = 2; i <= sqrt; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                if (num == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }


        }
    }
}
