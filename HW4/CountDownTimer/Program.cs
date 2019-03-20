using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDownTimer cdt = new CountDownTimer();
            cdt.CountDownHandler += new CountDownTimerEventHandler(CountDown1);
            int countdowntime;
            Console.WriteLine("How many seconds to countdown?");
            if (int.TryParse(Console.ReadLine(), out countdowntime))
                cdt.CountDown(countdowntime);
            else
                Console.WriteLine("Wrong input");

        }

        static void CountDown1(object sender, CountDownTimerEventArgs args)
        {
            while (args.Countdowntime > 0)
            {
                Console.WriteLine(args.Countdowntime--);
                Thread.Sleep(1000);
                if (args.Countdowntime == 0)
                {
                    Console.WriteLine("Time is up!");
                }
            }
        }



            

        

    }
}
