using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class outKeyword
    {
        static void Main(string[] args)
        {
            Employee(10, out int sal, out string nameEmp);
            Console.WriteLine(sal);
            Console.WriteLine(nameEmp);
        }
        // Out keyword is used when we want to return multiple values from method (with different datatypes
        static void Employee(int id, out int salary, out string name)
        {
            salary = 1000;
            name = "Shyam";
        }
    }
}
