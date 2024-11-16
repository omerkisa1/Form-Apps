using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        class Personel
        {
            private string ad;
            private string soyad;
            private string pozisyon;
            private double maas;
            private int calismaSuresi;

            public string Ad
            {
                get { return ad; }
                set { ad = value; }
            }

            public string Soyad
            {
                get { return soyad; }
                set { soyad = value; }
            }

            public string Pozisyon
            {
                get { return pozisyon; }
                set { pozisyon = value; }
            }

            public double Maas
            {
                get { return maas; }
                set
                {
                    if (value >= 0)
                        maas = value;
                    else
                        Console.WriteLine("Maaş negatif olamaz.");
                }
            }

            public int CalismaSuresi
            {
                get { return calismaSuresi; }
                set
                {
                    if (value >= 0)
                        calismaSuresi = value;
                    else
                        Console.WriteLine("Çalışma süresi negatif olamaz.");
                }
            }

            public void PersonelBilgiler()
            {
                Console.WriteLine("Ad: " + this.Ad + "\nSoyad: " + this.Soyad + "\nPozisyon: " + this.Pozisyon + "\nMaaş: " + this.Maas + "\nÇalışma Süresi: " + this.CalismaSuresi);
            }

            public double YillikIkramiye(string x)
            {
                x = x.ToLower();
                double ikramiye;

                if (x.Equals("yönetici"))
                {
                    ikramiye = (this.Maas * 20) / 100;
                }
                else
                {
                    ikramiye = (this.Maas * 10) / 100;
                }

                return ikramiye;
            }

            public Personel(string ad, string soyad, string pozisyon, double maas, int calismaSuresi)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.Pozisyon = pozisyon;
                this.Maas = maas;
                this.CalismaSuresi = calismaSuresi;
            }
        }

        class PersonelYonetimi
        {
            private List<Personel> personelListesi;

            public PersonelYonetimi()
            {
                personelListesi = new List<Personel>();
            }

            public void PersonelEkle(Personel personel)
            {
                personelListesi.Add(personel);
                Console.WriteLine("Personel eklendi: " + personel.Ad + " " + personel.Soyad);
            }

            public void TumPersonelleriListele()
            {
                Console.WriteLine("Tüm Personeller:");
                foreach (var personel in personelListesi)
                {
                    personel.PersonelBilgiler();
                    Console.WriteLine("--------------------------");
                }
            }

            public void PersonelAra(string ad)
            {
                bool bulundu = false;
                foreach (var personel in personelListesi)
                {
                    if (personel.Ad.ToLower() == ad.ToLower())
                    {
                        Console.WriteLine("Aranan Personel Bilgileri:");
                        personel.PersonelBilgiler();
                        bulundu = true;
                        break;
                    }
                }
                if (!bulundu)
                {
                    Console.WriteLine("Personel bulunamadı: " + ad);
                }
            }
        }

        static void Main(string[] args)
        {
            
            PersonelYonetimi yonetim = new PersonelYonetimi();

        
            Personel personel1 = new Personel("Ömer", "Kısa", "Öğrenci", 5000, 3);
            Personel personel2 = new Personel("Ali", "Yılmaz", "Yönetici", 10000, 5);

            yonetim.PersonelEkle(personel1);
            yonetim.PersonelEkle(personel2);


            yonetim.TumPersonelleriListele();

          
            yonetim.PersonelAra("Ömer");
            yonetim.PersonelAra("Mehmet");

            Console.ReadLine();
        }
    }
}
