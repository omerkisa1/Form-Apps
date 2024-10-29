using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Find out groups of consecutive numbers");
            string input;

            while(true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (input.Equals("0"))
                    break;
                
                if(int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                    Console.WriteLine($"{number} added.");
                }
                else
                {
                    Console.WriteLine("Invalid number.");
                }

                if (numbers.Count == 0)
                {
                    Console.WriteLine("You should enter numbers or press 0 to quit");
                    return;
                }
            }
            FindConsecutiveGroups(numbers);
        }
        static void FindConsecutiveGroups(List<int> numbers)
        {
            List<string> groups = new List<string>();

            int startPoint = numbers[0];
            int endPoint = numbers[0];
            // this method will point the start/end points and will check If they consecutive groups
            for (int i = 1; i < numbers.Count; i++)

            {
                if (numbers[i] == endPoint + 1)
                {
                    // check out It's endpoint + 1
                    endPoint = numbers[i];
                }
                else
                {
                    groups.Add(startPoint == endPoint ? $"{startPoint}" : $"{startPoint}-{endPoint}");
                    startPoint = endPoint = numbers[i];
                }
            }
            groups.Add(startPoint == endPoint ? $"{startPoint}" : $"{startPoint}-{endPoint}");

            Console.WriteLine("ConsecutiveGroups: " + string.Join(", ", groups));
            Console.ReadKey();


        }
    }
}
