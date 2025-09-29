using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_Practical_2_
{
    internal class Task3
    {
        public static void task3code()
        {
            Console.WriteLine("Enter number");
            int number = Int32.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("number is 0");
            }
            else if(number > 0) 
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is negative");
            }

        }
    }
}
