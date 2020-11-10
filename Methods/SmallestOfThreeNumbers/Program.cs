using System;
using System.Linq;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            PrintSmallestNumber(numbers);
        }

        private static void PrintSmallestNumber(int[] numbers)
        {
            Console.WriteLine(numbers.Min());
        }
    }
}
