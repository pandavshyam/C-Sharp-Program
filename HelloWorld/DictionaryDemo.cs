using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            // Typed Safe generic type collection
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(100, "C++");
            dict1.Add(200, "C#");
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            // Not typed safe non-generic collection (Similar to Dictionary but this is not typed safe)
            Hashtable ht = new Hashtable();
            ht.Add("1","Shyam");
            ht.Add("2", "Pandav");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
