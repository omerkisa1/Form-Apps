using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            string input;
            Console.WriteLine("Enter a number to add an element to the array(press q to exit):");

            while (true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if(input.ToLower() == "q")
                {
                    break;
                }
                numbers.Add(int.Parse(input));
                Console.WriteLine($"Sayı {input} eklendi.");
            }
            numbers.Sort();
            Console.WriteLine("Number you'd like to search: ");
            string searchNumber = Console.ReadLine();

            int index = Array.BinarySearch(string <numbers>, searchNumber);

        }
    }
}
