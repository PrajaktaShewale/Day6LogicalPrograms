using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        DateTime dateTime = DateTime.Now;
        public void Start()
        {
            int startHr = dateTime.Hour;
            int StartMin = dateTime.Minute;
            int startSec = dateTime.Second;
            int startMilliSec = dateTime.Millisecond;
            Console.WriteLine("Press s to Start");
            string data = Console.ReadLine().ToLower();
            if (data.Equals("s"))
            {
                Console.WriteLine(startMilliSec);
                Console.WriteLine("Press x for Exit");
                string stop = Console.ReadLine().ToLower();
                if (stop.Equals("x"))
                {
                    DateTime dateTime1 = DateTime.Now;
                    Console.WriteLine(dateTime1.Millisecond);
                    int stopHr = dateTime1.Hour;
                    int stopMin = dateTime1.Minute;
                    int stopSec = dateTime1.Second;
                    int stopMilliSec = dateTime1.Millisecond;
                    Console.WriteLine("Stopwatch details:- Hours:" + (stopHr - startHr) + "Minutes:" + (stopMin - StartMin)
                        + "Seconds:" + (stopSec - startSec) + "Milliseconds:" + (stopMilliSec - startMilliSec));
                }
            }
        }
    }
}
