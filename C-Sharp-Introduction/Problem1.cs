using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Introduction
{
    class Problem1
    {
        static bool IsStringPalindrome(string inputString)
        {
            int i = 0, j = inputString.Length - 1;

            while (i < j)
            {
                if (inputString[i] != inputString[j])
                {
                    return false;
                }
                i++; j--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Console.WriteLine(IsStringPalindrome(inputString));
        }
    }
}
