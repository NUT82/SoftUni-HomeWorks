using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lengthOne = input[0];
            int lengthTwo = input[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < lengthOne; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < lengthTwo; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            if (firstSet.Count < secondSet.Count)
            {
                foreach (var item in firstSet.Where(e => secondSet.Contains(e)))
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                foreach (var item in secondSet.Where(e => firstSet.Contains(e)))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
