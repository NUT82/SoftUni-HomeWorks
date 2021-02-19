using System;
using System.Collections;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomSet<string> items = new CustomSet<string>(Console.ReadLine().Split(", "));

            string[] command = Console.ReadLine().Split(" - ");
            while (command[0] != "Craft!")
            {
                switch (command[0])
                {
                    case "Collect":
                        items.Collect(command[1]);
                        break;
                    case "Drop":
                        items.Drop(command[1]);
                        break;
                    case "Combine Items":
                        string oldItem = command[1].Split(":")[0];
                        string newItem = command[1].Split(":")[1];
                        items.CombineItems(oldItem, newItem);
                        break;
                    case "Renew":
                        items.Renew(command[1]);
                        break;
                }
                command = Console.ReadLine().Split(" - ");
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }

    internal class CustomSet<T> : IEnumerable<T>
    {
        private readonly List<T> items;

        public CustomSet(params T[] items)
        {
            this.items = new List<T>(items);
        }

        public void Collect(T item)
        {
            if (!items.Contains(item))
            {
                items.Add(item);
            }
        }

        public bool Drop(T item) => items.Remove(item);

        public void CombineItems(T oldItem, T newItem)
        {
            if (items.Contains(oldItem))
            {
                items.Insert(items.IndexOf(oldItem) + 1, newItem);
            }
        }

        public void Renew(T item)
        {
            int currIndex = items.IndexOf(item);
            if (currIndex >= 0 && currIndex != items.Count - 1)
            {
                items.RemoveAt(currIndex);
                items.Add(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
