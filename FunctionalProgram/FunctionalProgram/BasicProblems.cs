using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class BasicProblems
    {
        public void Harmonic_No()
        {
            Console.WriteLine("Enter the last harmonic number\n");
            double num = Convert.ToDouble(Console.ReadLine());
            double harmonicSum = 0;
            for (double i = 1; i <= num; i++)
            {
                Console.WriteLine("1/" + i + "=" + (1 / i));
                harmonicSum += (1 / i);
            }
            Console.WriteLine("\nThe Sum of harmonic number is :" + harmonicSum);
        }
    }
        
    
}
