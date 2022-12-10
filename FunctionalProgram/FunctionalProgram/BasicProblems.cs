using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class BasicProblems
    {
        public void Swap_Two_Number()
        {
            int num1 = 15;
            int num2 = 25;
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Swapping of number is  : " + num1 + " " + num2);
        }
            
        
    }
}
