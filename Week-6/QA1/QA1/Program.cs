using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA1
{
    class Program
    {
        class Yazar
        {
            string name { get; set; }
            string country { get; set; }
            public List<Kitap> Books = new List<Kitap>();

            public Yazar(string name, string country)
            {
                this.name = name;
                this.country = country;
            }

            public void addBook(Kitap kitap)
            {
                Books.Add(kitap);
            }
            public void ListBooks()
            {
                Console.WriteLine($"Yazar: {name}, Ülke: {country}");
                Console.WriteLine("Kitaplar:");
                foreach (var book in Books)
                {
                    Console.WriteLine($"- {book.title} (ISBN: {book.ISBN})");
                }
            }

        }
        class Kitap
        {
            public string title { get; set; }
            public string ISBN { get; set; }

            public Kitap(string title, string ISBN)
            {
                this.title = title;
                this.ISBN = ISBN;
            }
        }
        static void Main(string[] args)
        {
 
            Yazar yazar = new Yazar("Orhan Pamuk", "Türkiye");
            Kitap kitap1 = new Kitap("Kırmızı Saçlı Kadın", "123456789");
            Kitap kitap2 = new Kitap("Masumiyet Müzesi", "987654321");


            yazar.addBook(kitap1);
            yazar.addBook(kitap2);


            yazar.ListBooks();

            Console.ReadLine();
        }
    }
}
