using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownTimer
{
    delegate void CountDownTimerEventHandler(CountDownTimer cdt, CountDownTimerEventArgs args);
    class CountDownTimer
    {
        //public int multifunc { get; set; }

        public event CountDownTimerEventHandler CountDownHandler;


        public void CountDown(int t)
        {
            CountDownTimerEventArgs args = new CountDownTimerEventArgs()
            {
                Countdowntime = t
            };

            CountDownHandler(this, args);
        }


        //public void ShowTime()
        //{
        //    Console.WriteLine(Countdowntime);
        //    if(Countdowntime == 0)
        //    {
        //        Console.WriteLine("Time is up!");
        //    }
        //}

        public void Subtract(int t)
        {

        }
    }
}

