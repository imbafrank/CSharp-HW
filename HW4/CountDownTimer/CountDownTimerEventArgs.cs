using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownTimer
{
    class CountDownTimerEventArgs: EventArgs
    {
        public int Countdowntime { get; set; }


        public CountDownTimerEventArgs(int Countdowntime)
        {
            this.Countdowntime = Countdowntime;
        }

        public CountDownTimerEventArgs()
        {

        }
    }
}
