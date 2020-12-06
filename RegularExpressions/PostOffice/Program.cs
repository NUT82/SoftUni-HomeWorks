using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPartPattern = @".*([#$%*&])(?<letters>[A-Z]+)\1.*";
            string secondPartPattern = @".*?(\d{2}):(\d{2}).*?";
            string thirdPartPattern = @"^([A-Z].*)$";

            string[] threeParts = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            string letters = Regex.Match(threeParts[0], firstPartPattern).Groups["letters"].Value;

            Dictionary<char, int> firstLetterAndLength = new Dictionary<char, int>();
            foreach (Match match in Regex.Matches(threeParts[1], secondPartPattern))
            {
                char firstLetter = (char)int.Parse(match.Groups[1].Value);
                int length = int.Parse(match.Groups[2].Value) + 1;
                if (letters.Contains(firstLetter) && !firstLetterAndLength.ContainsKey(firstLetter))
                {
                    firstLetterAndLength.Add(firstLetter, length);
                }
            }

            string[] words = threeParts[2].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> validWords = new List<string>();
            foreach (string word in words)
            {
                Match match = Regex.Match(word, thirdPartPattern);
                if (match.Success)
                {
                    validWords.Add(match.Groups[1].Value);
                }
            }

            foreach (char letter in letters)
            {
                foreach (string word in validWords.Where(x => x[0] == letter && x.Length == firstLetterAndLength[letter]))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
