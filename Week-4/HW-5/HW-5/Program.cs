using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public Book(string title, string author)
            {
                this.Title = title;
                this.Author = author;
            }

            public void GetBookInfo()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}");
            }
        }

        class Library
        {
            private List<Book> books;

            public Library()
            {
                this.books = new List<Book>();
            }

            public void AddBook(Book newBook)
            {
                this.books.Add(newBook);
                Console.WriteLine($"The book \"{newBook.Title}\" has been added to the library.");
            }

            public void ListBooks()
            {
                Console.WriteLine("Listing all books in the library:");
                foreach (var book in books)
                {
                    book.GetBookInfo();
                }
            }
        }

        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            Book book2 = new Book("1984", "George Orwell");

            library.AddBook(book1);
            library.AddBook(book2);

            library.ListBooks();
        }
    }
}
