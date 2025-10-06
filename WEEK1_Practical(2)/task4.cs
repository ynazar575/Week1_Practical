using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_Practical_2_
{
    internal class task4
    {
        public static void task4code()
        {
            bool leap_year = false;
            Console.WriteLine("Enter year");
            int year = Int32.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0)
            {
                leap_year = true;
            }
            else if (year % 400 == 0)
            {
                leap_year = false;
            }
            if (leap_year == true)
            {
                Console.WriteLine("year is a leap year");
            }
            else
            {
                Console.WriteLine("year is not a leap year");
            }
        }
    }
}
