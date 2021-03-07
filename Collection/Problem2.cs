using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Calculator<T>
    {
        public T ADD(T inp1, T inp2)
        {
            dynamic a = inp1;
            dynamic b = inp2;
            return (a + b);
        }
        public T SUB(T inp1, T inp2)
        {
            dynamic a = inp1;
            dynamic b = inp2;
            return (a - b);
        }
    }

    class Problem2
    {
        static void Main(string[] args)
        {
            int i1 = 10, i2 = 222;
            float f1 = (float)10.34, f2 = (float)2.45;
            Calculator<int> calculateInt = new Calculator<int>();
            int result1 = calculateInt.ADD(i1, i2);
            int result2 = calculateInt.SUB(i1, i2);
            Calculator<float> calculateFloat = new Calculator<float>();
            float result3 = calculateFloat.ADD(f1, f2);
            float result4 = calculateFloat.SUB(f1, f2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

        }

    }
}
