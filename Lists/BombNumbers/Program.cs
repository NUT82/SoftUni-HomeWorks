using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            int searchedIndex = integers.FindIndex(x => x == bomb);
            while (searchedIndex != -1)
            {
                int startIndex = searchedIndex - power;
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                int endIndex = searchedIndex + power;
                if (endIndex >= integers.Count)
                {
                    endIndex = integers.Count - 1;
                }
                int count = endIndex - startIndex + 1;

                integers.RemoveRange(startIndex, count);
                searchedIndex = integers.FindIndex(x => x == bomb);
            }

            Console.WriteLine(integers.Sum());
        }
    }
}
