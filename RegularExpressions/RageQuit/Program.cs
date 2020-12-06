using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\D+)(\d{0,2})";
            string line = Console.ReadLine().ToUpper();

            MatchCollection matches = Regex.Matches(line, pattern);
            StringBuilder stringBuilder = new StringBuilder(100000);
            
            foreach (Match match in matches)
            {
                int count = int.Parse(match.Groups[2].Value);
                string str = String.Concat(Enumerable.Repeat(match.Groups[1].Value, count));
                
                stringBuilder.Append(str);
            }
            Console.WriteLine($"Unique symbols used: {stringBuilder.ToString().Distinct().Count()}");
            Console.WriteLine(stringBuilder);
        }

    }
}
