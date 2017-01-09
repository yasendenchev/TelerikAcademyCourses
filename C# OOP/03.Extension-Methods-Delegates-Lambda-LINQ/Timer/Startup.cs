using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace Timer
{
    class Startup
    {
       public delegate DateTime Test();

        static void Main(string[] args)
        {
            var myDel = new Test(PrintTime);

            //System.Timers.Timer aTimer = new System.Timers.Timer();
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //aTimer.Interval = 100000;
            //aTimer.Enabled = true;

            //Console.WriteLine("Press \'q\' to quit the sample.");
            //while (Console.Read() != 'q') ;


            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"The time now is: {myDel.Invoke()}");
            }

        }

        static DateTime PrintTime()
        {
            return DateTime.Now;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("hi");
        }
       
    }
}
