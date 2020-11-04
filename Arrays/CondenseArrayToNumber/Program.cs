using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an array of integers and condense them by summing adjacent couples of elements until a single integer is obtained. For example, if we have 3 elements {2, 10, 3}, we sum the first two and the second two elements and obtain {2+10, 10+3} = {12, 13}, then we sum again all adjacent elements and obtain {12+13} = {25}.
            int[] arrayOfIntegers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            while (arrayOfIntegers.Length != 1)
            {
                for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
                {
                    arrayOfIntegers [i] = arrayOfIntegers[i] + arrayOfIntegers[i + 1];
                }
                arrayOfIntegers = arrayOfIntegers.SkipLast(1).ToArray();
            }
            Console.WriteLine(arrayOfIntegers[0]);
        }
    }
}
