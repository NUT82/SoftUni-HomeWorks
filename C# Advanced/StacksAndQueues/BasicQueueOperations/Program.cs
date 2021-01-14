using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToAdd = input[0];
            int elementsToRemove = input[1];
            int lookupElement = input[2];
            Queue<int> integers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < elementsToRemove; i++)
            {
                integers.Dequeue();
            }
            if (integers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (integers.Contains(lookupElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(integers.Min());
                }
            }
        }
    }
}
