using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Introduction
{
    /*
     Create an array of the above Books (Problem 6). Accept input for multiple books and Display their information
    */
    class Problem7
    {
        static void Main(string[] args)
        {

            // Creating list of books
            List<Book> bookList = new List<Book>();
            Console.WriteLine("Enter Number of Books to which you want to add into List: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Taking input and storing into list
            for (int i = 0; i < num; i++)
            {
                Book bookObj = new Book();
                Console.WriteLine($"Enter Book ID for {i+1}");
                Console.WriteLine("Enter Book ID");
                bookObj.bookID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Book Name");
                bookObj.title = Console.ReadLine();
                Console.WriteLine("Enter Book Price");
                bookObj.price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Book Type Number");
                int bookType = Convert.ToInt32(Console.ReadLine());
                if (bookType == 1)
                    bookObj.BookType = Book.bookType.Magazine;
                else if (bookType == 2)
                    bookObj.BookType = Book.bookType.Novel;
                else if (bookType == 3)
                    bookObj.BookType = Book.bookType.ReferenceBook;
                else if (bookType == 4)
                    bookObj.BookType = Book.bookType.Miscellaneous;
                bookList.Add(bookObj);
            }

            // Printing all books
            foreach (Book item in bookList)
            {
                Console.WriteLine("Book Details : ");
                Console.WriteLine(item.bookID);
                Console.WriteLine(item.title);
                Console.WriteLine(item.price);
                Console.WriteLine(item.BookType);
                Console.WriteLine("-------------");
            }
        }
    }
}
