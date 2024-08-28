/*
Develop an application that simulates a library system. Create a class named LibraryBook with properties Title, 
Author, and Available. Implement a method BorrowBook that updates the availability status. Instantiate multiple 
book objects, perform book borrowing, and display the updated library status.
*/

using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"You have borrowed \"{Title}\" by {Author}.");
            }
            else
            {
                Console.WriteLine($"\"{Title}\" by {Author} is not available.");
            }
        }

        public void DisplayStatus()
        {
            string status = Available ? "Available" : "Not available";
            Console.WriteLine($"Title: {Title}, Author: {Author}, Status: {status}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate multiple book objects
            List<LibraryBook> books = new List<LibraryBook>
            {
                new LibraryBook("Dracula", "Bram Stoker", true),
                new LibraryBook("1984", "George Orwell", true),
                new LibraryBook("The Catcher in the Rye", "J.D. Salinger", true)
            };

            // Display initial library status
            Console.WriteLine("Initial Library Status:");
            foreach (var book in books)
            {
                book.DisplayStatus();
            }

            Console.WriteLine();

            // Borrow some books
            books[0].BorrowBook();
            books[1].BorrowBook();
            books[1].BorrowBook(); // Attempt to borrow an already borrowed book

            Console.WriteLine();

            // Display updated library status
            Console.WriteLine("Updated Library Status:");
            foreach (var book in books)
            {
                book.DisplayStatus();
            }

            Console.ReadKey();
        }
    }
}



