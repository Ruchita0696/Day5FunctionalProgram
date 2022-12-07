using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class BasicProblems
    {
        public void Leap_Year()
        {
            Console.WriteLine("enter a year : ");
            int year = int.Parse(Console.ReadLine());

            if (year > 1000 && year < 9999)
            {
                if (year % 4 == 0 || year % 400 == 0)
                {
                    Console.WriteLine("Leap year.");
                }
                else
                {
                    Console.WriteLine("not leap year");
                }
            }
            else
            {
                Console.WriteLine("Wrong Input .");
            }
        }
    }
}
