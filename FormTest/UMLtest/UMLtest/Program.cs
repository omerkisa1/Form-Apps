using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtest
{
    class Program
    {
        public class Araba
        {
            public string Plaka { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            private readonly Motor _motor;  // Composition ilişkisi - private readonly

            public Araba(string plaka, string marka, string model, Motor motor)
            {
                Plaka = plaka;
                Marka = marka;
                Model = model;
                _motor = motor ?? throw new ArgumentNullException(nameof(motor));
            }

            public void ArabaSur(Surucu surucu)
            {
                if (surucu == null)
                    throw new ArgumentNullException(nameof(surucu));

                Console.WriteLine($"{surucu.Ad} adlı sürücü {Plaka} plakalı aracı kullanıyor.");
            }

            public void MotorBilgileriniGoster()
            {
                Console.WriteLine($"Motor Gücü: {_motor.Guc} HP");
                Console.WriteLine($"Motor Hacmi: {_motor.Hacim} cc");
            }
        }

        public class Motor
        {
            public int Guc { get; set; }
            public int Hacim { get; set; }

            public Motor(int guc, int hacim)
            {
                Guc = guc;
                Hacim = hacim;
            }
        }

        public class Surucu
        {
            public string Ad { get; set; }
            public int EhliyetNo { get; set; }

            public Surucu(string ad, int ehliyetNo)
            {
                Ad = ad;
                EhliyetNo = ehliyetNo;
            }
        }

        public class Kiralama
        {
            private List<Araba> _arabalar;  // private field

            public Kiralama()
            {
                _arabalar = new List<Araba>();
            }

            public void ArabaEkle(Araba araba)
            {
                if (araba == null)
                    throw new ArgumentNullException(nameof(araba));

                _arabalar.Add(araba);
                Console.WriteLine($"{araba.Plaka} plakalı araç filoya eklendi.");
            }

            public void ArabaCikar(string plaka)
            {
                var araba = _arabalar.FirstOrDefault(a => a.Plaka == plaka);
                if (araba != null)
                {
                    _arabalar.Remove(araba);
                    Console.WriteLine($"{plaka} plakalı araç filodan çıkarıldı.");
                }
            }

            public void FiloyuListele()
            {
                Console.WriteLine("Filodaki Araçlar:");
                foreach (var araba in _arabalar)
                {
                    Console.WriteLine($"Plaka: {araba.Plaka}, Marka: {araba.Marka}, Model: {araba.Model}");
                }
            }
        }
    }
}
