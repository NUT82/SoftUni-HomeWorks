using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            int count = numbers.Count - 1;
            for (int i = 0; i < count; i++, count--)
            {
                numbers[i] += numbers[count];
                numbers.RemoveAt(count);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
