using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Calisan
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string pozisyon { get; set; }
        public int maas { get; set; }

        public Calisan(string ad, string soyad, string pozisyon, int maas)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.pozisyon = pozisyon;
            this.maas = maas;
        }

        public void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {this.ad} \nSoyad: {this.soyad} \nPozisyon: {this.pozisyon} \nMaaş: {this.maas}");
        }


    }
    public class Yazilimci : Calisan
    {
        string yazilimDili { get; set; }

        public Yazilimci(string ad, string soyad, string pozisyon, int maas, string yazilimDili)
    : base(ad, soyad, pozisyon, maas) 
        {
            this.yazilimDili = yazilimDili;
        }
        public void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {this.ad} \nSoyad: {this.soyad} \nPozisyon: {this.pozisyon} \nMaaş: {this.maas} \nYazılım Dili: {this.yazilimDili}");
        }

    }
    public class Muhasebeci: Calisan
    {
        string muhasebeYazilimi { get; set; }

        public Muhasebeci(string ad, string soyad, string pozisyon, int maas, string muhasebeYazilimi)
: base(ad, soyad, pozisyon, maas)
        {
            this.muhasebeYazilimi = muhasebeYazilimi;
        }
        public void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {this.ad} \nSoyad: {this.soyad} \nPozisyon: {this.pozisyon} \nMaaş: {this.maas} \nMuhasebe Yazılım Dili: {this.muhasebeYazilimi}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan = new Calisan("Omer", "Kisa", "Developer", 1000);
            Yazilimci yazilimci = new Yazilimci("Bora", "Kısa", "Muhendis", 2000, "Python");
            Muhasebeci muhasebeci = new Muhasebeci("Emir", "Kısa", "Muhasebeci", 3000, "Excel");

            Console.WriteLine("Seçim yap\n 1-) Çalışan Listele \n 2-) Yazılımcı Listele Listele \n 3-) Muhasebeci Listele");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    calisan.BilgiYazdir();
                    break;
                case 2:
                    calisan.BilgiYazdir();
                    break;
                case 3:
                    calisan.BilgiYazdir();
                    break;
                default:
                    break;
            }
            Console.ReadLine();



        }
    }
}
