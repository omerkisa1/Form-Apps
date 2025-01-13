using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTest1
{
    class Program
    {

        public class HataYonetimiOrnekleri
        {
            public void DosyaIslemleri()
            {
                try
                {
                    // Riskli kod bloğu
                    string dosyaIcerigi = File.ReadAllText("C:\\Users\\omere\\Desktop\\test.txt");
                    Console.WriteLine(dosyaIcerigi);
                }
                catch (FileNotFoundException ex)
                {
                    // Spesifik hata yakalama
                    Console.WriteLine($"Dosya bulunamadı: {ex.Message}");
                    // Çıktı: Dosya bulunamadı: Could not find file 'olmayan_dosya.txt'
                }
                catch (Exception ex)
                {
                    // Genel hata yakalama
                    Console.WriteLine($"Bir hata oluştu: {ex.Message}");
                }
                finally
                {
                    // Her durumda çalışacak kod
                    Console.WriteLine("İşlem tamamlandı");
                    // Çıktı: İşlem tamamlandı
                }
            }


            static void Main(string[] args)
            {
                HataYonetimiOrnekleri a = new HataYonetimiOrnekleri();
                a.DosyaIslemleri();
                Console.ReadKey();
            }
        }
    }
}
