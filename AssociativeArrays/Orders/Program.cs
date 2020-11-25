using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] currLine = command.Split();
                string name = currLine[0];
                double price = double.Parse(currLine[1]);
                int quantity = int.Parse(currLine[2]);
                Product product = new Product(price, quantity);
                if (products.ContainsKey(name))
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                }
                else
                {
                    products.Add(name, product);
                }

                command = Console.ReadLine();
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.TotalPrice():F2}");
            }
        }
    }

    public class Product
    {
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        internal double TotalPrice()
        {
            return Price * Quantity;
        }
    }
}
