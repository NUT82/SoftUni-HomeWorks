using System;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a list of integers and find the longest increasing subsequence (LIS). If several such exist, print the leftmost.
            int[] arrayOfIntegers = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
            int minNumberInArray = arrayOfIntegers.Min();
            int maxNumberInArray = arrayOfIntegers.Max();
            int maxIncrSubLength = 0;
            int[] longestArrayOfIncSub = new int[arrayOfIntegers.Length];

            for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
            {
                int startIndex = i + 1;
                while (startIndex < arrayOfIntegers.Length)
                {
                    int currIncrSubLength = 0;
                    int[] arrayOfCurrLongSub = new int[arrayOfIntegers.Length];
                    arrayOfCurrLongSub[currIncrSubLength] = arrayOfIntegers[i];
                    for (int j = startIndex; j < arrayOfIntegers.Length; j++)
                    {
                        if (arrayOfIntegers[j] > arrayOfCurrLongSub[currIncrSubLength])
                        {
                            currIncrSubLength++;
                            arrayOfCurrLongSub[currIncrSubLength] = arrayOfIntegers[j];
                        }
                        else
                        {
                            if (currIncrSubLength > maxIncrSubLength)
                            {
                                maxIncrSubLength = currIncrSubLength;
                                longestArrayOfIncSub = arrayOfCurrLongSub.ToArray();
                            }
                        }
                    }
                    startIndex++;
                }
            }
            Console.WriteLine(string.Join(" ", longestArrayOfIncSub));
        }
    }
}
