using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingHW1
{
    class Program
    {
        public int Sum(int a, int b)
        {
            return a+b;
        }
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Sum(int[] arr)
        {
            int totalSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalSum += arr[i];
            }
            return totalSum;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Sum of 2 and 3: " + program.Sum(2, 3));               
            Console.WriteLine("Sum of 1, 2, and 3: " + program.Sum(1, 2, 3));        

            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum of array: " + program.Sum(numbers));             
            Console.ReadLine();
        }
    }
}
