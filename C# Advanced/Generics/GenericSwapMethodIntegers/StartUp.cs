using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < number; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(list, indexes[0], indexes[1]);
            Print(list);
        }

        static void Swap<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        static void Print<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

    }
}
