using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            RemoveNegativeNumbers(numbers);
            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static void RemoveNegativeNumbers(List<int> numbers)
        {
            numbers.RemoveAll(x => x < 0);
        }


    }
}
