using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(numberN);

            for (int i = 0; i < numberN; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 1; i <= numberN; i++)
            {
                Console.WriteLine($"{i}.{products[i - 1]}");
            }
        }
    }
}
