using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower two rows (each holding 2 * k integers):
            int[] arrayOfIntegers = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
            int[] upperRow = new int[arrayOfIntegers.Length / 2];
            int counter = 0;
            for (int i = arrayOfIntegers.Length / 4 - 1; i >= 0; i--)
            {
                upperRow[counter] = arrayOfIntegers[i];
                counter++;
            }
            for (int i = arrayOfIntegers.Length - 1; i >= arrayOfIntegers.Length - 1 - (arrayOfIntegers.Length / 4 - 1); i--)
            {
                upperRow[counter] = arrayOfIntegers[i];
                counter++;
            }

            //output
            for (int i = 0; i < upperRow.Length; i++)
            {
                Console.Write($"{upperRow[i] + arrayOfIntegers[i + arrayOfIntegers.Length / 4]} ");
            }
        }
    }
}
