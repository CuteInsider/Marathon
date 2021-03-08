using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Marathon
{
    class Time
    {
        static public TimeSpan RemainingTime;

        public Time()//Конструктор таймера
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        public void timer_Tick(object source, EventArgs e)
        {
            DateTime Event = new DateTime(2018, 09, 01, 9, 0, 0);
            RemainingTime = Event - DateTime.Now;
        }
    }
}
