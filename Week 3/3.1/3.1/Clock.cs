using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Clock
    {
        private Counter seconds;
        private Counter minutes;
        private Counter hours;

        public Clock()
        {
            seconds = new Counter("Seconds");
            minutes = new Counter("Minutes");
            hours = new Counter("Hours");

        }


        public void Tick()
        {

            if (seconds.Ticks == 59)
            {
                if (minutes.Ticks == 59)
                {
                    if (hours.Ticks == 23)
                    {
                        ClockReset();
                    }
                    else
                    {
                        hours.Increment();
                        seconds.Reset();
                        minutes.Reset();
                    }
                }
                else
                {
                    minutes.Increment();
                    seconds.Reset();
                }
            }
            else
            {
                seconds.Increment();
            }




        }

        public string Show()
        {
            string _result = $"{hours.Ticks.ToString("D2")}:{minutes.Ticks.ToString("D2")}:{seconds.Ticks.ToString("D2")}";
            return _result;
        }
        public void ClockReset()
        {
            seconds.Reset();
            minutes.Reset();
            hours.Reset();
        }
    }
}