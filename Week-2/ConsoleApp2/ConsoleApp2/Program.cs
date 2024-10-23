using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Lütfen bir metin girin:");
        string input = Console.ReadLine();

      
        string[] words = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

      
        foreach (var word in words)
        {
            string lowerWord = word.ToLower(); 
            if (wordCount.ContainsKey(lowerWord))
            {
                wordCount[lowerWord]++;
            }
            else
            {
                wordCount[lowerWord] = 1;
            }
        }

        Console.WriteLine("\nKelimelerin frekansları:");
        foreach (var item in wordCount.OrderBy(w => w.Key)) 
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
