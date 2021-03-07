using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Introduction
{
    /*
     Create a WordCounter Application. Your application will accept a string from the user and count the number
     of words in the string and also the number of characters in the string. Display the words in the ascending order
    */
    class Problem5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string userInput = Console.ReadLine();
            string[] userInputArray = userInput.Split();

            // Counting number of words
            int numberOfWords = userInputArray.Length;
            Console.WriteLine("Number of Words : ");
            Console.WriteLine(numberOfWords);

            // Counting Number of chars
            int numberOfChar = 0;

            foreach (var item in userInputArray)
            {
                numberOfChar += item.Length;
            }
            Console.WriteLine("Number of Char : ");
            Console.WriteLine(numberOfChar);

            // Sorting array
            Array.Sort(userInputArray);

            // Count of each word in string
            foreach (var item in userInputArray)
            {
                Console.Write(userInputArray.Count(a => a == item));
                Console.Write(" : " + item);
                Console.WriteLine();
            }
        }
    }
}
