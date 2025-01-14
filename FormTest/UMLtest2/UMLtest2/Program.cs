using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtest2
{
    class Program
    {
        class Ogretmen
        {
            public string İsim { get; set; }
            public List<Ders> dersler = new List<Ders>();
            public Ogretmen(string isim)
            {
                this.İsim = isim; 
            }
            public void DersEkle(Ders ders)
            {
                if(dersler.Contains(ders))
                {
                    Console.WriteLine("Bu ders zaten mevcut");
                }
                else
                {
                    dersler.Add(ders);
                    Console.WriteLine($"{ders.Adı} dersi eklendi");
                }
            }
            public void DersleriListele()
            {
                foreach(var ders in dersler)
                {
                    Console.WriteLine(ders.Adı +"\n");
                }
            }


        }
        class Ders
        {
            public string Adı { get; set; }

            public Ders(string adi)
            {
                this.Adı = adi;
            }
        }

        static void Main(string[] args)
        {

            Ogretmen ogr = new Ogretmen("Omer");
            Ders drs1 = new Ders("matematik");
            Ders drs2 = new Ders("fizik");
            Ders drs3 = new Ders("kimya");

            ogr.DersEkle(drs1);
            ogr.DersEkle(drs2);
            ogr.DersEkle(drs3);
            ogr.DersleriListele();
            Console.ReadKey();

        }
    }
}
