using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private readonly List<Product> bag;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public IReadOnlyCollection<Product> Bag => bag.AsReadOnly();

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public double Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        
        internal void Buy(Product product)
        {
            if (Money >= product.Price)
            {
                Money -= product.Price;
                bag.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} - ");
            if (Bag.Count == 0)
            {
                sb.AppendLine("Nothing bought");
            }
            else
            {
                sb.AppendJoin(", ", Bag);
            }
            return sb.ToString();
        }
    }
}
