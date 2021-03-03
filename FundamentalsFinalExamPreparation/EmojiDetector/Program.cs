using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([:*])\1(?<emoji>[A-Z][a-z]{2,})\1\1";
            Regex regex = new Regex(pattern);


            string text = Console.ReadLine();
            long threshold =    text.ToCharArray()
                                    .Where(c => char.IsDigit(c))
                                    .Select(c => int.Parse(c.ToString()))
                                    .Aggregate(1, (a, b) => a * b);



            MatchCollection result = regex.Matches(text);

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{result.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in result)
            {
                int sum = 0;
                foreach (var symbol in item.Groups["emoji"].Value)
                {
                    sum += symbol;
                }
                if (sum > threshold)
                {
                    Console.WriteLine(item.Value);
                }
                
            }

             
        }
    }
}
