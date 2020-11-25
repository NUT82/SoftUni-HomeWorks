using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            int countOfWords = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfWords; i++)
            {
                string currWord = Console.ReadLine();
                string currSynonym = Console.ReadLine();
                if (synonyms.ContainsKey(currWord))
                {
                    synonyms[currWord].Add(currSynonym);
                }
                else
                {
                    synonyms.Add(currWord, new List<string>() { currSynonym });
                }
            }

            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
