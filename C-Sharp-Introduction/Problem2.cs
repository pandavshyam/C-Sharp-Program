using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Introduction
{
    class Problem2
    {
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
