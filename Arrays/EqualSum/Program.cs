using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that determines if there exists an element in the array such that the sum of the elements on its left is equal to the sum of the elements on its right (there will never be more than 1 element like that). If there are no elements to the left / right, their sum is considered to be 0. Print the index that satisfies the required condition or "no" if there is no such index.
            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int wantedIndex = -1;
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers.Take(i).ToArray().Sum() == arrayOfIntegers.TakeLast(arrayOfIntegers.Length - 1 - i).ToArray().Sum())
                {
                    wantedIndex = i;
                    break;
                }
            }
            if (wantedIndex < 0)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(wantedIndex);
            }
        }
    }
}
