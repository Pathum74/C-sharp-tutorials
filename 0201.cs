/*
1.	Create a C# console application that defines a class called Book with properties Title and Author. 
Instantiate an object of this class, set values for the properties, and display the information on the console.
*/

using System;


namespace Tutorial
{
    class Book
    {

        public string Title { get; set; }
        public string Authur { get; set; }
    }

    class program
    {

        static void Main(string[] args)
        {
            Book book = new Book();

            book.Title = "Harry Potter";
            book.Authur = "J. K. Rowling";

            Console.WriteLine("Book Information=");
            Console.WriteLine("Title:  " + book.Title);
            Console.WriteLine("Author: " + book.Authur);

            Console.ReadKey();
        }
    }

}

