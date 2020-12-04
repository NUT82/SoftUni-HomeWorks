using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan	Ivanov
            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";
            Regex regex = new Regex(pattern);
            string text = Console.ReadLine();
            var output = regex.Matches(text);
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
