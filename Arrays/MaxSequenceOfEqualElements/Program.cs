using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.
            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counterOfEqualElements = 1;
            int maxCounterOfEqualElements = 1;
            int equalElement = -1;
            for (int i = 1; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] == arrayOfIntegers[i - 1])
                {
                    counterOfEqualElements++;
                    if (counterOfEqualElements > maxCounterOfEqualElements)
                    {
                        maxCounterOfEqualElements = counterOfEqualElements;
                        equalElement = arrayOfIntegers[i - 1];
                    }
                }
                else
                {
                    counterOfEqualElements = 1;
                }
            }
            if (equalElement < 0)
            {
                equalElement = arrayOfIntegers[0];
                maxCounterOfEqualElements = counterOfEqualElements;
            }
            for (int i = 0; i < maxCounterOfEqualElements; i++)
            {
                Console.Write(equalElement + " ");
            }
        }
    }
}