using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex("^[0-9]+$");

            Console.WriteLine("Enter two numbers separately:");
            string n1 = Console.ReadLine();
            if (!reg.Match(n1).Success)
            {
                Console.WriteLine("Error, please verify your input");
                return;
            }

            string n2 = Console.ReadLine();

            if (reg.Match(n1).Success && reg.Match(n2).Success)
            {
                int result = int.Parse(n1) * int.Parse(n2);
                Console.WriteLine("Their product is: " + result);
            }
            else
            {
                Console.WriteLine("Error, please verify your input");
            }

        }
    }
}



