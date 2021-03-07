using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Introduction
{
    /*
        Create a class ‘Book’ which contains the members like bookId, title, price, bookType, etc. 

        The type of the book should be enumerated datatypes with values Magazine, Novel, ReferenceBook & Miscellaneous 
    
        Write a Console Application to do the following Tasks:	 

        a) Accept Details of the Book 

        b) Display the details of the book. The type of the book should be displayed as string  : eg Magazine
    */
    class Problem6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Book Details: ");
            try
            {
                // Getting Book Details
                int bookID = Convert.ToInt32(Console.ReadLine());
                string title = Console.ReadLine();
                double price = Convert.ToDouble(Console.ReadLine());
                int bookType = Convert.ToInt32(Console.ReadLine());

                // Creating object of Book
                Book bookObj = new Book() { bookID = bookID, title = title, price = price};

                if (bookType == 1)
                    bookObj.BookType = Book.bookType.Magazine;
                else if (bookType == 2)
                    bookObj.BookType = Book.bookType.Novel;
                else if (bookType == 3)
                    bookObj.BookType = Book.bookType.ReferenceBook;
                else if (bookType == 4)
                    bookObj.BookType = Book.bookType.Miscellaneous;

                // Printing Book Details
                Console.WriteLine("Book Details");
                Console.WriteLine(bookObj.bookID);
                Console.WriteLine(bookObj.title);
                Console.WriteLine(bookObj.price);
                Console.WriteLine(bookObj.BookType);

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter correct details");
            }
        }
    }


    class Book
    {
        public int bookID { get; set; }
        public string title { get; set; }
        public double price { get; set; }

        public enum bookType
        {
            Magazine,
            Novel,
            ReferenceBook,
            Miscellaneous
        }

        public bookType BookType { get; set; }
    }
}
