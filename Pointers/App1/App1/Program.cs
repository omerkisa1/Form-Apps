using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int* ptr = &x; 

            Console.WriteLine($"Değer: {x}");
            Console.WriteLine($"Adres: {(int)ptr}");

            *ptr = 20; 
            Console.WriteLine($"Yeni Değer: {x}");
        }
    }
}
