using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.
            int[] arrayOfIntegers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            foreach (var item in arrayOfIntegers)
            {
                if (item % 2 == 0)
                {
                    sumEven += item;
                }
                else
                {
                    sumOdd += item;
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
