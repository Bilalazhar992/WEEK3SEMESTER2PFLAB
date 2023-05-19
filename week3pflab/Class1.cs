using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3pflab
{
    public class ClockType
    {
        public int  hour;
        public int  minute;
        public int secound;
        public  ClockType(int h)
        {
            hour = h;
           
        }
        public ClockType(int h,int m)
        {
            hour = h;
            minute = m;
            
        }
        public ClockType(int h, int m,int s)
        {
            hour = h;
            minute = m;
            secound = s;
        }
        public void incrementsecound()
        {
            secound++;
        }
        public void incrementminute()
        {
            minute++;
        }
        public void incrementhour()
        {
            hour++;
        }
        public void printtime()
        {
            Console.WriteLine(hour + "-" + minute + "-" + secound);
        }
        public bool isEqual(int hours,int minutes,int secounds)
        {
            if(hour==hours && minute==minutes && secound==secounds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqualByObject(ClockType s)
        {
            if (hour == s.hour && minute == s.minute && secound == s.secound)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ShowElapsedTime(ClockType s)
        {
            hour = s.hour - 0;
            minute = s.minute - 0;
            secound = s.secound - 0;
            Console.Write("Elapsed Time: ");
            Console.WriteLine(hour + "-" + minute + "-" + secound);
            hour = hour * 3600;
            minute = minute * 60;
            secound = secound + hour + minute;
            Console.WriteLine("Elapsed Time: {0}",secound + "secounds");
        }
        public void ShowRemainingTime(ClockType s,ClockType m)
        {
            hour = s.hour - m.hour;
            minute = s.minute - m.minute;
            secound = s.secound - m.secound;
            Console.Write("Remaining Time: ");
            Console.WriteLine(hour + "-" + minute + "-" + secound);
            hour = hour * 3600;
            minute = minute * 60;
            secound = secound + hour + minute;
            Console.WriteLine("Remaining Time: {0}", secound+"secounds");
        }
        public void ShowDifference(ClockType m, ClockType s)
        {
            hour = s.hour - m.hour;
            minute = s.minute - m.minute;
            secound = s.secound - m.secound;
            Console.Write("Difference: ");
            Console.WriteLine(hour + "-" + minute + "-" + secound);
        }

    }

}
