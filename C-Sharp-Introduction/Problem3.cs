using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Introduction
{
    /*
        Write a method that checks if given number (positive integer) contains digit 5. 
        Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc. 

        Expected input and output 

        IfNumberContains5(7201452) → true  

        IfNumberContains5(87301) → false 
     */
    class Problem3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfNumberContains5(87301));
        }

        private static bool IfNumberContains5(int num)
        {
            while (num != 0)
            {
                int remainder = num % 10;
                if (remainder == 5)
                    return true;
                num = num / 10;
            }
            return false;
        }
    }
}
