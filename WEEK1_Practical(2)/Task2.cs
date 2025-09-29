using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_Practical_2_
{
    internal class Task2
    {
        public static void task2Code()
        {
            
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());
            if(age < 13)
            {
                Console.WriteLine("you are a child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("you are a teen");
            }
            else if(age < 110 && age > 19)
            {
                Console.WriteLine("your an adult");
            }
            else
            {
                Console.WriteLine("invalid age");
            }
        }
    }
}
