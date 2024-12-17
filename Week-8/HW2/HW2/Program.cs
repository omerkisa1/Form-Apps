using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Hayvan
    {
        string ad { get; set; }
        string tur { get; set; }
        int yas { get; set; }

        public Hayvan(string ad, string tur, int yas)
        {
            this.ad = ad;
            this.tur = tur;
            this.yas = yas;
        }
        public void sesCikar()
        {
            Console.WriteLine("Hayvan Sesi");
        }
    }
    public class Memeli : Hayvan
    {
        string tuyRengi { get; set; }
        public Memeli(string ad, string tur, int yas, string tuyRengi)
            :base(ad, tur, yas)
        {
            this.tuyRengi = tuyRengi;
        }
        public void sesCikar()
        {
            Console.WriteLine("Memeli Sesi");
        }
    }

    public class Kus : Hayvan
    {
        int kanatGenisligi { get; set; }
        public Kus(string ad, string tur, int yas, int kanatGenisligi)
            : base(ad, tur, yas)
        {
            this.kanatGenisligi = kanatGenisligi;
        }
        public void sesCikar()
        {
            Console.WriteLine("Kuş Sesi");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan("Hayvan", "Kara", 5);
            Memeli memeli = new Memeli("Balina", "Deniz", 20, "Siyah");
            Kus kus = new Kus("Serçe", "Hava", 1, 5);
            Console.WriteLine("Seçim yap\n 1-) Hayvan Sesi \n 2-) Memeli Sesi Listele \n 3-) Kus Sesi");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    hayvan.sesCikar();
                    break;
                case 2:
                    memeli.sesCikar();
                    break;
                case 3:
                    kus.sesCikar();
                    break;
                default:
                    break;
            }
            Console.ReadLine();

        }
    }
}
