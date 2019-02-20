using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.DateTime;

namespace SimpleUtilityClass
{
    //Static classes can only
    //contain static members
    static class TimeUtilClass
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            //You can also write it as WriteLine(Now.ToShortTimesString()
        }
        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }
    }
}
