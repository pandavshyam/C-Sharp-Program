using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class ExceptionHandling
    {
        // User defind Exception
        class OddNumberException : Exception
        {
            public OddNumberException(string Message) : base(Message)
            {

            }
        }
        static void Main(string[] args)
        {
            // Simple Exception Code
            try
            {
                int i = 1;
                int j = 10;
                Console.WriteLine(j/i);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            // User defined
            try
            {
                OddNumber();
            }
            catch (OddNumberException)
            {
                Console.WriteLine("User defined exception");
            }
            
        }

        static void MultipleExceptionHandling()
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int c = a / b;
                Console.WriteLine(c);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by Zero Exception");
            }
        }

        static void OddNumber()
        {
            int num = int.Parse(Console.ReadLine());
            if (num %2 != 0)
            {
                throw new OddNumberException("Number is odd");
            }
            Console.WriteLine("Number is Even");
        }
    }
}
