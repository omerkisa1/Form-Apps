using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int fibo1 = 0;
            int fibo2 = 1;

 
            Console.WriteLine("Enter a number to find Fibonacci: ");
            int givenNumber = Convert.ToInt32(Console.ReadLine());

    
            if (givenNumber == 0)
            {
                Console.WriteLine("No Fibonacci numbers to display.");
            }
            else if (givenNumber == 1)
            {
                Console.WriteLine(fibo1);  
            }
            else
            {
                Console.WriteLine(fibo1);  
                Console.WriteLine(fibo2);  


                for (int i = 2; i < givenNumber; i++)
                {
                    int nextFibo = fibo1 + fibo2;
                    Console.WriteLine(nextFibo);  

            
                    fibo1 = fibo2;
                    fibo2 = nextFibo;
                }
            }

  
            Console.ReadLine();
        }
    }
}
