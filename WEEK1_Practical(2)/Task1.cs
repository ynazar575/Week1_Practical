using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_Practical_2_
{
    internal class Task1
    {
        public static void task1Code()
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());
            int age2 = age + 5;
            Console.WriteLine("hello " + name + " you will be " + age2 + " in 5 years");
        }

    }
}
