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
            int elementsToPush = input[0];
            int elementsToPop = input[1];
            int lookupElement = input[2];
            Stack<int> integers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < elementsToPop; i++)
            {
                integers.Pop();
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
