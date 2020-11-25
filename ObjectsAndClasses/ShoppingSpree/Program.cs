using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allPeoplesAndMoney = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] allProductsAndCosts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> peoples = new List<Person>(allPeoplesAndMoney.Length);
            foreach (var people in allPeoplesAndMoney)
            {
                string[] currPersonNameAndMoney = people.Split("=");
                Person currPerson = new Person(currPersonNameAndMoney[0], double.Parse(currPersonNameAndMoney[1]));
                peoples.Add(currPerson);
            }

            List<Product> products = new List<Product>(allProductsAndCosts.Length);
            foreach (var product in allProductsAndCosts)
            {
                string[] currProductAndCost = product.Split("=");
                Product currProduct = new Product(currProductAndCost[0], double.Parse(currProductAndCost[1]));
                products.Add(currProduct);
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] currComand = command.Split();
                string name = currComand[0];
                string product = currComand[1];
                Person currPerson = peoples.FirstOrDefault(n => n.Name == name);
                Product currProduct = products.FirstOrDefault(p => p.Name == product);
                peoples.Average(x => x.Money);
                if (currPerson.HasEnoughMoney(currProduct))
                {
                    currPerson.BuyProduct(currProduct);
                    Console.WriteLine($"{name} bought {product}");
                }
                else
                {
                    Console.WriteLine($"{name} can't afford {product}");
                }

                command = Console.ReadLine();
            }

            foreach (var person in peoples)
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> BagOfProducts { get; set; }

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            BagOfProducts.Add(product);
            Money -= product.Cost;
        }

        internal bool HasEnoughMoney(Product product)
        {
            if (Money >= product.Cost)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            if (BagOfProducts.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }

            return $"{Name} - {string.Join(", ", BagOfProducts)}";
        }
    }
}
