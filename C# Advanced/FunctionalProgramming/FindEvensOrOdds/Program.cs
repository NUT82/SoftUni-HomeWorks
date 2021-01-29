using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = input[0];
            int end = input[1];
            
            string filter = Console.ReadLine();
            
            Dictionary<string, Predicate<int>> evenOrOddPredicate = new Dictionary<string, Predicate<int>>()
            {
                { "even", n => n % 2 == 0 },
                { "odd", n => n % 2 != 0 }
            };
            Predicate<int> evenOdd = evenOrOddPredicate[filter];

            for (int i = start; i <= end; i++)
            {
                if (evenOdd(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
