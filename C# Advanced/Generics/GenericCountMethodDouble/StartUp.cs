using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < number; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            double elementToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(CountGreaterElement(list, elementToCompare));
        }

        static int CountGreaterElement<T>(List<T> list, T elementToCompare)
            where T : IComparable
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(elementToCompare) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
