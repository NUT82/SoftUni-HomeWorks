using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            int countElementsOfOldList = 0;
            do
            {
                countElementsOfOldList = numbers.Count;
                numbers = CopyTwoAdjacentEqualNumbers(numbers);
            } while (countElementsOfOldList != numbers.Count);

            Console.WriteLine(string.Join(" ", numbers));

        }

        private static List<double> CopyTwoAdjacentEqualNumbers(List<double> numbers)
        {
            int index = FirstIndexOfMinElementAdjacentEqualNumbers(numbers);
            if (index < 0)
            {
                return numbers;
            }
            numbers[index] += numbers[index + 1];
            numbers.RemoveAt(index + 1);
            return numbers;
        }

        private static int FirstIndexOfMinElementAdjacentEqualNumbers(List<double> numbers)
        {
            int result = -1;
            double minElement = double.MaxValue;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    if (numbers[i] < minElement)
                    {
                        minElement = numbers[i];
                        result = i - 1;
                    }
                }
            }

            return result;
        }
    }
}
