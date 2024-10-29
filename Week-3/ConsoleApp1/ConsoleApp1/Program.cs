using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a number to add an element to the array (press q to exit):");

            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                    Console.WriteLine($"{number} added.");
                }
                else
                {
                    Console.WriteLine("Invalid number.");
                }
            }

            numbers.Sort();
            // this part can be in while, cause may you like to keep searching till found it:)
            Console.Write("Number you'd like to search: ");
            string searchInput = Console.ReadLine();

            if (int.TryParse(searchInput, out int searchNumber))
            {
                int index = numbers.BinarySearch(searchNumber);

                if (index >= 0)
                {
                    Console.WriteLine($"Number found. Index: {index}");
                }
                else
                {
                    Console.WriteLine("No element in array.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }
}
