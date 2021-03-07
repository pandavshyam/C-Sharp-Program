using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Introduction
{
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
