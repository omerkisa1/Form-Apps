using System;
using System.Collections.Generic;

namespace AssociationHW2
{
    class Program
    {
        class Yazar
        {
            public string Name { get; set; }
            public string Country { get; set; }

            public List<Kitap> Kitaplar { get; set; }

            public Yazar(string name, string country)
            {
                Name = name;
                Country = country;
                Kitaplar = new List<Kitap>();
            }
            public void KitapEkle(Kitap kitap)
            {
                if (!Kitaplar.Contains(kitap))
                {
                    Kitaplar.Add(kitap);
                    kitap.Yazar = this; 
                }
            }
        }

        class Kitap
        {
            public string Baslik { get; set; }
            public DateTime YayinTarihi { get; set; }
            public Yazar Yazar { get; set; }

            public Kitap(string baslik, DateTime yayinTarihi)
            {
                Baslik = baslik;
                YayinTarihi = yayinTarihi;
            }

            public void YazarAtama(Yazar yazar)
            {
                if (Yazar != yazar)
                {
                    Yazar = yazar;
                    yazar.KitapEkle(this); 
                }
            }
        }

        static void Main(string[] args)
        {
       
            Yazar yazar1 = new Yazar("Orhan Pamuk", "Türkiye");
            Yazar yazar2 = new Yazar("J.K. Rowling", "İngiltere");

    
            Kitap kitap1 = new Kitap("Kırmızı Saçlı Kadın", new DateTime(2016, 9, 1));
            Kitap kitap2 = new Kitap("Harry Potter ve Felsefe Taşı", new DateTime(1997, 6, 26));

            kitap1.YazarAtama(yazar1);
            kitap2.YazarAtama(yazar2);


            Console.WriteLine($"{yazar1.Name} tarafından yazılan kitaplar:");
            foreach (var kitap in yazar1.Kitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik} ({kitap.YayinTarihi.Year})");
            }

            Console.WriteLine($"\n{yazar2.Name} tarafından yazılan kitaplar:");
            foreach (var kitap in yazar2.Kitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik} ({kitap.YayinTarihi.Year})");
            }
        }
    }
}
