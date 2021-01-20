using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shopsAndProductsPrices = new SortedDictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();
            while (command != "Revision")
            {
                string[] splitedCommand = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = splitedCommand[0];
                string product = splitedCommand[1];
                double price = double.Parse(splitedCommand[2]);

                if (!shopsAndProductsPrices.ContainsKey(shop))
                {
                    shopsAndProductsPrices.Add(shop, new Dictionary<string, double>());
                }

                if (!shopsAndProductsPrices[shop].ContainsKey(product))
                {
                    shopsAndProductsPrices[shop].Add(product, price);
                }

                command = Console.ReadLine();
            }

            foreach (var shop in shopsAndProductsPrices)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
