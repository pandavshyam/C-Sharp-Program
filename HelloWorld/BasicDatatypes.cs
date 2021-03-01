using System;

namespace HelloWorld
{
    class BasicDatatypes
    {
        public void BasicDatatypesHandler()
        {
            // Printing Hello World
            Console.WriteLine("Hello World!");

            // Printing Primitive datatypes
            byte number = 250;
            float floatNum = 10.1f;
            char charType = 'A';
            string name = "Shyam";
            bool isLoggedIn = false;
            var varType = 200;
            Console.WriteLine(varType);

            // byte minvalue
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            // float minvalue
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // Implicit type conversion
            byte a = 2;
            int b = a; // a is converted into int

            // Explicit type conversion
            int c = 10;
            byte d = (byte)c; //  Data loss can be there

            // Exception Handling
            try
            {
                string str = "1234";
                byte strToByte = Convert.ToByte(str);
                Console.WriteLine(strToByte);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Occured");
            }
        }
    }
}
