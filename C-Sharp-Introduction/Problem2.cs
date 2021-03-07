using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Introduction
{
    class Problem2
    {
        /*
            Given a string and substring, write a method that returns number of occurrences of substring in the string. 
            Assume that both are case-sensitive. You may need to use library function here. 

            Expected input and output 

            HowManyOccurrences("do it now", "do") → 1 HowManyOccurrences("empty", "d") → 0 
        */
        static void Main(string[] args)
        {
            string mainString = "empty", subString = "d";
            Console.WriteLine(HowManyOccurrences(mainString, subString));
        }

        private static int HowManyOccurrences(string mainString, string subString)
        {
            int count = 0;
            for (int i = 0; i <= mainString.Length - subString.Length; i++)
            {
                int j;
                for (j = 0; j < subString.Length; j++)
                {
                    if (mainString[i + j] != subString[j])
                        break;
                }
                if (j == subString.Length)
                    count++;
            }
            return count;
        }
    }
}
