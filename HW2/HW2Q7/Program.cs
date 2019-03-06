using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            int len;
            Console.WriteLine("Please enter the length of your array");
            string lenstr = Console.ReadLine();
            if (!int.TryParse(lenstr, out len))
            {
                Console.WriteLine("Error input!");
                return;
            }
            int[] a = new int[len];
            int max = 0, min = 0, sum = 0;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Please enter the NO."+(i+1)+" item of your array");
                string str = Console.ReadLine();
                int n;
                if (!int.TryParse(str, out n))
                {
                    Console.WriteLine("Error input!");
                    return;
                }
                if (i == 0)
                {
                    max = n;
                    min = n;
                }
                    

                a[i] = n;
                sum += n;

                if (n > max)
                {
                    max = n;
                }

                if (n < min)
                {
                    min = n;
                }
               
               
            }

            Console.WriteLine("Maximum value is " + max);
            Console.WriteLine("Minimum value is " + min);
            Console.WriteLine("Average value is " + sum/len);
            Console.WriteLine("Summation is " + sum);

        }
    }
}
