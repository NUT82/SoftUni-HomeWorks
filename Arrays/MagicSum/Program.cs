using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number. 
            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int wantedSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayOfIntegers.Length; j++)
                {
                    if (arrayOfIntegers[i] + arrayOfIntegers[j] == wantedSum)
                    {
                        Console.WriteLine($"{arrayOfIntegers[i]} {arrayOfIntegers[j]}");
                    }
                }
            }
        }
    }
}
