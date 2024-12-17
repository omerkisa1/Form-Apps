using System;

namespace AbstractClass1
{
    public abstract class Hesap
    {
        public string HesapNo { get; set; }
        public decimal Bakiye { get; set; }

        public Hesap(string hesapNo, decimal bakiye)
        {
            HesapNo = hesapNo;
            Bakiye = bakiye;
        }

        public virtual void ParaYatir(decimal miktar)
        {
            Bakiye += miktar;
        }

        public virtual void ParaCek(decimal miktar)
        {
            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");
            }
        }
    }

    public interface IBankaHesabi
    {
        DateTime HesapAcilisTarihi { get; set; }
        void HesapOzeti();
    }

    public class BirikimHesabi : Hesap, IBankaHesabi
    {
        public decimal FaizOrani { get; set; }
        public DateTime HesapAcilisTarihi { get; set; }

        public BirikimHesabi(string hesapNo, decimal bakiye, decimal faizOrani, DateTime hesapAcilisTarihi)
            : base(hesapNo, bakiye)
        {
            FaizOrani = faizOrani;
            HesapAcilisTarihi = hesapAcilisTarihi;
        }

        public override void ParaYatir(decimal miktar)
        {
            decimal faiz = miktar * FaizOrani / 100;
            Bakiye += miktar + faiz;
        }

        public void HesapOzeti()
        {
            Console.WriteLine($"Birikim Hesap No: {HesapNo}, Bakiye: {Bakiye} TL, Faiz Orani: {FaizOrani}%, Acilis Tarihi: {HesapAcilisTarihi.ToShortDateString()}");
        }
    }

    public class VadesizHesap : Hesap, IBankaHesabi
    {
        public DateTime HesapAcilisTarihi { get; set; }
        private decimal IslemUcreti = 5;

        public VadesizHesap(string hesapNo, decimal bakiye, DateTime hesapAcilisTarihi)
            : base(hesapNo, bakiye)
        {
            HesapAcilisTarihi = hesapAcilisTarihi;
        }

        public override void ParaCek(decimal miktar)
        {
            decimal totalMiktar = miktar + IslemUcreti;
            if (Bakiye >= totalMiktar)
            {
                Bakiye -= totalMiktar;
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye ve işlem ücreti");
            }
        }

        public void HesapOzeti()
        {
            Console.WriteLine($"Vadesiz Hesap No: {HesapNo}, Bakiye: {Bakiye} TL, Acilis Tarihi: {HesapAcilisTarihi.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BirikimHesabi birikimHesap = new BirikimHesabi("123456", 1000, 2.5m, DateTime.Now);
            VadesizHesap vadesizHesap = new VadesizHesap("654321", 500, DateTime.Now);

            birikimHesap.ParaYatir(500);
            birikimHesap.ParaCek(200);
            birikimHesap.HesapOzeti();

            vadesizHesap.ParaYatir(300);
            vadesizHesap.ParaCek(700);
            vadesizHesap.HesapOzeti();

            Console.ReadKey();
        }
    }
}
