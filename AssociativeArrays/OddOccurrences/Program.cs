using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var word in line)
            {
                if (words.ContainsKey(word.ToLower()))
                {
                    words[word.ToLower()]++;
                }
                else
                {
                    words.Add(word.ToLower(), 1);
                }
            }

            foreach (var item in words.Where(x => x.Value % 2 == 1))
            {
                Console.Write(item.Key + " ");
            }
        }
    }
}
