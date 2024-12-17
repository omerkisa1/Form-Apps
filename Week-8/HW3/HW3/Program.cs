using System;

namespace HW3
{

    public class Hesap
    {
        public string hesapNumarasi { get; set; }
        public double bakiye { get; set; }
        public string hesapSahibi { get; set; }

        public Hesap(string hesapNumarasi, double bakiye, string hesapSahibi)
        {
            this.hesapNumarasi = hesapNumarasi;
            this.bakiye = bakiye;
            this.hesapSahibi = hesapSahibi;
        }

        public virtual void ParaYatir(double miktar)
        {
            bakiye += miktar;
            Console.WriteLine($"{miktar} TL hesaba yatırıldı. Yeni bakiye: {bakiye} TL");
        }

        public virtual void ParaCek(double miktar)
        {
            if (miktar <= bakiye)
            {
                bakiye -= miktar;
                Console.WriteLine($"{miktar} TL çekildi. Kalan bakiye: {bakiye} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Hesap Sahibi: {hesapSahibi}, Hesap No: {hesapNumarasi}, Bakiye: {bakiye} TL");
        }
    }


    public class VadesizHesap : Hesap
    {
        public double ekHesapLimiti { get; set; }

        public VadesizHesap(string hesapNumarasi, double bakiye, string hesapSahibi, double ekHesapLimiti)
            : base(hesapNumarasi, bakiye, hesapSahibi)
        {
            this.ekHesapLimiti = ekHesapLimiti;
        }

        public override void ParaCek(double miktar)
        {
            if (miktar <= bakiye + ekHesapLimiti)
            {
                bakiye -= miktar;
                Console.WriteLine($"{miktar} TL çekildi. Kalan bakiye: {bakiye} TL (Ek Hesap Limit Dahil)");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye ve ek hesap limiti!");
            }
        }

        public override void ParaYatir(double miktar)
        {
            base.ParaYatir(miktar);
            Console.WriteLine("Vadesiz hesaba para yatırıldı.");
        }
    }

    public class VadeliHesap : Hesap
    {
        public int vadeSuresi { get; set; }
        public double faizOrani { get; set; }
        private bool vadeDolduMu;

        public VadeliHesap(string hesapNumarasi, double bakiye, string hesapSahibi, int vadeSuresi, double faizOrani)
            : base(hesapNumarasi, bakiye, hesapSahibi)
        {
            this.vadeSuresi = vadeSuresi;
            this.faizOrani = faizOrani;
            this.vadeDolduMu = false;
        }

        public void VadeDoldur()
        {
            vadeDolduMu = true;
            bakiye += bakiye * (faizOrani / 100);
            Console.WriteLine($"Vade doldu! Faiz uygulandı. Yeni bakiye: {bakiye} TL");
        }

        public override void ParaCek(double miktar)
        {
            if (!vadeDolduMu)
            {
                Console.WriteLine("Vade süresi dolmadan para çekemezsiniz!");
            }
            else
            {
                base.ParaCek(miktar);
            }
        }

        public override void ParaYatir(double miktar)
        {
            base.ParaYatir(miktar);
            Console.WriteLine("Vadeli hesaba para yatırıldı.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Türünü Seçin:\n1-) Vadesiz Hesap\n2-) Vadeli Hesap");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    VadesizHesap vadesizHesap = new VadesizHesap("123456", 1000, "Ali Yılmaz", 500);
                    vadesizHesap.BilgiYazdir();
                    vadesizHesap.ParaYatir(300);
                    vadesizHesap.ParaCek(1500);
                    vadesizHesap.BilgiYazdir();
                    break;

                case 2:
                    VadeliHesap vadeliHesap = new VadeliHesap("654321", 2000, "Ayşe Demir", 30, 5);
                    vadeliHesap.BilgiYazdir();
                    vadeliHesap.ParaYatir(500);
                    vadeliHesap.ParaCek(1000);
                    vadeliHesap.VadeDoldur();
                    vadeliHesap.ParaCek(1000); 
                    vadeliHesap.BilgiYazdir();
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
