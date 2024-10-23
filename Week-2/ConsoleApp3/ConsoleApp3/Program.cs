using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a number is an Armstrong number or not: ");

            int givenNumber = int.Parse(Console.ReadLine());

     
            int digitCount = Math.Abs(givenNumber).ToString().Length;

            int tempNumber = givenNumber; 
            int sum = 0;  

    
            while (tempNumber > 0)
            {
                int digit = tempNumber % 10;  
                sum += (int)Math.Pow(digit, digitCount);  
                tempNumber /= 10;  
            }


            if (sum == givenNumber)
            {
                Console.WriteLine($"{givenNumber} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{givenNumber} is not an Armstrong number.");
            }
        }
    }
}
