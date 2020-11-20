using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] currLine = line.Split();
                string serialNumber = currLine[0];
                string itemName = currLine[1];
                int itemQuantitiy = int.Parse(currLine[2]);
                double price = double.Parse(currLine[3]);
                Item currItem = new Item(itemName, price);
                Box currBox = new Box(serialNumber, currItem, itemQuantitiy);
                boxes.Add(currBox);

                line = Console.ReadLine();
            }

            List<Box> sortedBoxes = boxes.OrderBy(x => x.PriceForBox).ToList();
            sortedBoxes.Reverse();

            foreach (var box in sortedBoxes)
            {
                box.ToSpecialFormat();
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForBox { get; set; }

        public Box(string serialNumber,Item item, int itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.ItemName = item.Name;
            this.ItemQuantity = itemQuantity;
            this.PriceForBox = itemQuantity * item.Price;
        }

        internal void ToSpecialFormat()
        {
            Console.WriteLine(this.SerialNumber);
            Console.WriteLine($"-- {this.ItemName} – ${this.PriceForBox / this.ItemQuantity:F2}: {this.ItemQuantity}");
            Console.WriteLine($"-- ${this.PriceForBox:F2}");
        }
    }
}
