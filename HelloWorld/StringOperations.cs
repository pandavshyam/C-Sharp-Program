using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class StringOperations
    {
        static void Main(string [] args)
        {
            // String Comparision
            string strName = "FirstString";
            string strName1 = " FirstString ";
            if (strName.Equals(strName1)) // or strName == strName1
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
            // Compare to will return 0 if both strings are equal
            // will return 1 if str1 > str2
            // will return -1 if str2 > str1
            int output = strName.CompareTo(strName1);

            // Trim
            strName1 = strName1.Trim();

            // String to int
            string num = "1234h";
            //int toNum = int.Parse(num);
            //int toNum1 = Convert.ToInt32(num);

            // TryParse will try to parse first argument to int else it will store value 0 in out int parameter
            int.TryParse("1234s", out int result);

            // Use of var
            var a = 100; // a will be int

            // Join string
            string str1 = "Shyam";
            string str2 = "Pandav";

            // String will join by first arugument
            string wholeString = String.Join(" ",str1, str2);
            Console.WriteLine(wholeString);

            // Date
            DateTime dt = new DateTime(2000, 01, 10);
            Console.WriteLine(dt.ToString());
        }
    }
}
