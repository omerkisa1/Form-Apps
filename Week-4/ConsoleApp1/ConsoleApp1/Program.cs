using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kitap
    {
        string baslik;
        string yazar;
        int sayfaSayisi = 100;

        public Kitap(string baslik, string yazar)
        {
            baslik = baslik;
            yazar = yazar;
        }
        public void KitapBilgisiGoster()
        {
            Console.WriteLine("baslik: "+ baslik+ "\n" + "Yazar: " + yazar +  "\n" + "sayfa sayisi : " + sayfaSayisi);
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            Kitap kitap = new Kitap("harry potter", "J. K. Rowling");
            kitap.KitapBilgisiGoster();
        }
    }
}
