using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numbersCounts = new Dictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var item in input)
            {
                if (!numbersCounts.ContainsKey(item))
                {
                    numbersCounts.Add(item, 1);
                }
                else
                {
                    numbersCounts[item]++;
                }
            }

            foreach (var number in numbersCounts)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
