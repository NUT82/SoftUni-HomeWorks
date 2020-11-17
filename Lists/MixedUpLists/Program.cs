using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLists = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondLists = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            int minListCount = Math.Min(firstLists.Count, secondLists.Count);
            List<int> newLists = new List<int>(minListCount * 2);
            int lastIndexSecondList = secondLists.Count - 1;
            for (int i = 0; i < minListCount; i++, lastIndexSecondList--)
            {
                newLists.Add(firstLists[i]);
                newLists.Add(secondLists[lastIndexSecondList]);
            }

            int max = 0;
            int min = 0;

            if (firstLists.Count > secondLists.Count)
            {
                max = Math.Max(firstLists[firstLists.Count - 1], firstLists[firstLists.Count - 2]);
                min = Math.Min(firstLists[firstLists.Count - 1], firstLists[firstLists.Count - 2]);
            }
            else
            {
                max = Math.Max(secondLists[0], secondLists[1]);
                min = Math.Min(secondLists[0], secondLists[1]);
            }

            List<int> output = newLists.Where(x => x > min && x < max).ToList();
            output.Sort();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
