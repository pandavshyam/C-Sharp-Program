using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    /*
     
    */

    class GenericDictonary<T1, T2> : IEnumerable
    {
        Dictionary<T1, T2> dict = new Dictionary<T1, T2>();
        public void Add(T1 ke, T2 val)
        {
            dict.Add(ke, val);
        }

        public IEnumerator GetEnumerator()
        {
            return dict.GetEnumerator();

        }

    }

    class Problem1
    {
        static void Main(string[] args)
        {
            GenericDictonary<int, string> dic = new GenericDictonary<int, string>();
            dic.Add(1, "Hello");
            dic.Add(2, "World");

            foreach (var d in dic)
            {
                Console.WriteLine(d);
            }

            GenericDictonary<int, int> dic2 = new GenericDictonary<int, int>();
            dic2.Add(1, 100);
            dic2.Add(2, 200);
            dic2.Add(3, 200);

            foreach (var d in dic2)
            {
                Console.WriteLine(d);
            }


        }
    }
}
