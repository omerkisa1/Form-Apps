using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Add your elements to find median and arithmetic mean");
            string input;

            while(true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (input.Equals("0"))
                    break;

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
            // we are sorting cause if it's odd we will found the answer easily


            if (numbers.Count % 2 == 0)
            {   
                //median
                int middleElement1 = numbers[(numbers.Count / 2) - 1];
                int middleElement2 = numbers[numbers.Count / 2];
                //arithmetic mean
                //int sum = numbers.Sum();
                // you can actually go with that way using the sum method and divide it to len but not necessary cause we found the both middle element

                int arithMeticSum = middleElement1 + middleElement2;
                Console.WriteLine("Median: " + arithMeticSum / 2);
                Console.WriteLine("Arithmetic Mean: " + arithMeticSum / 2);
                Console.ReadKey();
            }
            else
            {
                // if our array len is odd that means median and arithmetic mean is equals cause we sorted the array
                int middleElement = numbers[numbers.Count / 2];
                Console.WriteLine("Median: " + middleElement);
                Console.WriteLine("Arithmetic mean: " + middleElement);
                Console.ReadKey();

                // 0(nlogn)

            }

        }
    }
}
