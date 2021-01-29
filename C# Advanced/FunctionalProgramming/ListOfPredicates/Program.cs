using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<int, List<int>, bool> filter = (x, list) =>
            {
                foreach (var item in list)
                {
                    if (x % item != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            Console.WriteLine(string.Join(" ", Enumerable.Range(1, end).Where(n => filter(n, dividers))));

        }
    }
}
