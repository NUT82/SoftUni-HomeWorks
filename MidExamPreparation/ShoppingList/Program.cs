using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomSet<string> items = new CustomSet<string>(Console.ReadLine().Split("!"));

            string[] command = Console.ReadLine().Split();
            while (command[0] != "Go" && command[1] != "Shopping!")
            {
                switch (command[0])
                {
                    case "Urgent":
                        items.Urgent(command[1]);
                        break;
                    case "Unnecessary":
                        items.Unnecessary(command[1]);
                        break;
                    case "Correct":
                        string oldItem = command[1];
                        string newItem = command[2];
                        items.Correct(oldItem, newItem);
                        break;
                    case "Rearrange":
                        items.Rearrange(command[1]);
                        break;
                }
                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }

    internal class CustomSet<T> : IEnumerable<T>
    {
        private Dictionary<T, int> items;
        private int lastIndex;

        public CustomSet(params T[] items)
        {
            this.items = new Dictionary<T, int>();
            for (int i = 0; i < items.Length; i++)
            {
                this.items.Add(items[i], i);
            }
            lastIndex = items.Length;
        }

        public void Urgent(T item)
        {
            if (!items.ContainsKey(item))
            {
                items = items.ToDictionary(kvp => kvp.Key, kvp => kvp.Value + 1);
                items.Add(item, 0);
                lastIndex++;
            }
        }

        public void Correct(T oldItem, T newItem)
        {
            if (items.ContainsKey(oldItem))
            {
                int index = items[oldItem];
                items.Remove(oldItem);
                items.Add(newItem, index);
            }
        }

        public bool Unnecessary(T item) => items.Remove(item);

        public void Rearrange(T item)
        {
            if (Unnecessary(item))
            {
                items.Add(item, lastIndex);
                lastIndex++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items.OrderBy(v => v.Value))
            {
                yield return item.Key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
