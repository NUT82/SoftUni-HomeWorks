using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two arrays and print on the console whether they are identical or not. Arrays are identical if their elements are equal. If the arrays are identical find the sum of the first one and print on the console following message: "Arrays are identical. Sum: {sum}", otherwise find the first index where the arrays differ and print on the console following message: "Arrays are not identical. Found difference at {index} index".
            int[] firstIntegerArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondIntegerArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isIdentical = false;
            int indexDfrOfArrays = 0;
            int sum = 0;
            
            if (firstIntegerArray.Length > secondIntegerArray.Length)
            {
                int index = 0;
                indexDfrOfArrays = secondIntegerArray.Length;
                foreach (var item in firstIntegerArray)
                {
                    if (item != secondIntegerArray[index])
                    {
                        indexDfrOfArrays = index;
                        break;
                    }
                    index++;
                }
            }
            else if(secondIntegerArray.Length > firstIntegerArray.Length)
            {
                int index = 0;
                indexDfrOfArrays = firstIntegerArray.Length;
                foreach (var item in secondIntegerArray)
                {
                    if (item != firstIntegerArray[index])
                    {
                        indexDfrOfArrays = index;
                        break;
                    }
                    index++;
                }
            }
            else
            {
                int index = 0;
                indexDfrOfArrays = -1;
                foreach (var item in firstIntegerArray)
                {
                    sum += item;
                    if (item != secondIntegerArray[index])
                    {
                        indexDfrOfArrays = index;
                        break;
                    }
                    index++;
                }
                if (indexDfrOfArrays == -1)
                {
                    isIdentical = true;
                }
            }
            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexDfrOfArrays} index");
            }
        }
    }
}
