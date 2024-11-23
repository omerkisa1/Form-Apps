using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerHW1
{
    class Program
    {
        class Library
        {
            string[] library = { "book1", "book2", "book3", "book4", "book5", "book6" };

            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < library.Length)
                    {
                        return library[index]; 
                    }
                    throw new IndexOutOfRangeException("Invalid index");
                }
                set
                {
                    if (index >= 0 && index < library.Length)
                    {
                        library[index] = value; 
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Invalid index");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Library library = new Library();

           
            Console.WriteLine(library[2]); 

           
            library[2] = "newBook";
            Console.WriteLine(library[2]);

            
            try
            {
                Console.WriteLine(library[-1]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); 
            }

            Console.ReadLine();
        }
    }
}
