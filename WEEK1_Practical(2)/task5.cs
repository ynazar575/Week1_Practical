using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_Practical_2_
{
    internal class task5
    {
        public static void task5code()
        {
            Console.WriteLine("Enter number");
            int number = Int32.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
 
            else
            {
                Console.WriteLine("number is odd");
            }

        }
    }
}
