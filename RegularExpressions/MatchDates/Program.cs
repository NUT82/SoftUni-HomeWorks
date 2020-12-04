using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([/.-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            Regex regex = new Regex(pattern);
            string text = Console.ReadLine();
            var output = regex.Matches(text);

            foreach (Match item in output)
            
            {
                Console.WriteLine($"Day: {item.Groups["day"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
            }
        }
    }
}