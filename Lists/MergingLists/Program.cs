using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbersFirst = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> numbersSecond = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<double> numbersNew = new List<double>(Math.Max(numbersFirst.Count, numbersSecond.Count));
            int min = Math.Min(numbersFirst.Count, numbersSecond.Count);

            for (int i = 0; i < min; i++)
            {
                numbersNew.Add(numbersFirst[i]);
                numbersNew.Add(numbersSecond[i]);
            }

            if (numbersFirst.Count > numbersSecond.Count)
            {
                AddRestElementsToList(numbersNew, numbersFirst, numbersSecond.Count, numbersFirst.Count);
            }
            else
            {
                AddRestElementsToList(numbersNew, numbersSecond, numbersFirst.Count, numbersSecond.Count);
            }

            Console.WriteLine(string.Join(" ", numbersNew));
        }

        private static void AddRestElementsToList(List<double> resultNumbers, List<double> numbers, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                resultNumbers.Add(numbers[i]);
            }
        }
    }
}