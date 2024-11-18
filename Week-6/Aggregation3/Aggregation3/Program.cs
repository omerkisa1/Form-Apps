using System;
using System.Collections.Generic;

namespace Aggregation2
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Central Library");
            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");

            library.AddBook(book1);
            library.AddBook(book2);

            foreach (var book in library.Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
}
