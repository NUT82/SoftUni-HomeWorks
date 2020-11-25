using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine().Replace(" ", "");

            Dictionary<char, int> chars = new Dictionary<char, int>();
            foreach (var item in line)
            {
                if (chars.ContainsKey(item))
                {
                    chars[item]++;
                }
                else
                {
                    chars.Add(item, 1);
                }
            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
