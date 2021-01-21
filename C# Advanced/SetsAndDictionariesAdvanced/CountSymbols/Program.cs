using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> charactersCount = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (!charactersCount.ContainsKey(symbol))
                {
                    charactersCount.Add(symbol, 1);
                }
                else
                {
                    charactersCount[symbol]++;
                }
            }

            foreach (var symbol in charactersCount)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
