using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Introduction
{
    class Problem4
    {
        /*
                Lookup the System.DateTime structure. This type contains a large amount of functionality that 
                allows a user to perform all sorts of interesting operations with dates and times. Use System.DateTime 
                along with System.Console to implement a simple C# program that does the following: 

                Ask the user for their birthday. It will probably easiest to ask year, then month, then day rather 
                than parsing a combined string reliably.  

                Calculate the age of the user.  

                Check to see if the age of the user is impossible. For example, if the user is not yet born, output 
                an error message. If the user claims to be 135 years old, then let them know that's not possible. 

                Output the age of the user to the console.  

                If it is the user's birthday, output a nice message.  
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Birth Year, Month, Date: ");
            try
            {
                // Taking input from user
                int year = Convert.ToInt32(Console.ReadLine());
                int month = Convert.ToInt32(Console.ReadLine());
                int date = Convert.ToInt32(Console.ReadLine());

                DateTime userDOB = new DateTime(year, month, date);

                int userAgeInYears = DateTime.Today.Year - year;

                // Check valid date
                if (year > DateTime.Today.Year || userAgeInYears > 135)
                    throw new ArgumentOutOfRangeException();

                // Calculating User Age
                Console.WriteLine("Your Age : ");
                Console.WriteLine(userAgeInYears);

                // Checking whether it is birthday
                if (month.Equals(DateTime.Today.Month) && date.Equals(DateTime.Today.Day))
                    Console.WriteLine("Happy Birthday");


            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Age is not possible...");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect Input Value");
            }

        }
    }
}
