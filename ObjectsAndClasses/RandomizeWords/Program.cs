using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random randomWord = new Random();
            for (int i = 0; i < words.Count; i++)
            {
                int newWordPlace = randomWord.Next(words.Count);
                string currWord = words[i];
                words[i] = words[newWordPlace];
                words[newWordPlace] = currWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
