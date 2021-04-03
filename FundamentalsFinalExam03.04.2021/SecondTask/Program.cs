using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!([A-Z][a-z]{2,})!:\[([A-Za-z]{8,})\]";

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string currInput = Console.ReadLine();
                Match match = Regex.Match(currInput, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    
                    Console.Write($"{match.Groups[1]}: ");
                    Console.WriteLine(string.Join(" ", match.Groups[2].Value.ToCharArray().Select(c => (int)c)));
                }
            }
        }
    }
}
