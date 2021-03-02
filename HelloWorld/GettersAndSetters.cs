using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class MyClass
    {
        private int myVar;
        public int propertyForMyVar
        {
            get { return myVar; }
            set { myVar = value; }
        }
    }

    class Indexers
    {
        private string[] stringArray = new string[10];
        public string this[int i]
        {
            get
            {
                return stringArray[i];
            }
            set
            {
                stringArray[i] = value;
            }
         }
    }
    class GettersAndSetters
    {
        static void Main(string[] args)
        {
            Indexers Team = new Indexers();
            Team[0] = "Rocky";
            Team[1] = "Teena";
            Team[2] = "Ana";
            Team[3] = "Victoria";
            Team[4] = "Yani";
            Team[5] = "Mary";
            Team[6] = "Gomes";
            Team[7] = "Arnold";
            Team[8] = "Mike";
            Team[9] = "Peter";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Team[i]);
            }
        }
    }
}
