using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][\dA-Za-z]{4,}[A-Z]@#+";
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                string productGroup = "00";
                if (Regex.IsMatch(input, pattern))
                {
                    if (Regex.Match(input, pattern).Value.Any(c => Char.IsDigit(c)))
                    {
                        productGroup = TakeDigits(Regex.Match(input, pattern).Value);
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }

        private static string TakeDigits(string value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var symbol in value.Where(c => Char.IsDigit(c)))
            {
                sb.Append(symbol);
            }

            return sb.ToString();
        }
    }
}
