using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array from the console and sum only the even numbers.
            int[] arrayOfIntegers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sumEven = 0;
            foreach (var item in arrayOfIntegers.Where(x => x % 2 == 0))
            {
                sumEven += item;
            }
            Console.WriteLine(sumEven);
        }
    }
}
