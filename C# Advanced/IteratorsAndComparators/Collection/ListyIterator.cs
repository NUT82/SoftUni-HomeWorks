using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        int index;
        private readonly List<T> collection;

        public ListyIterator(params T[] elements)
        {
            collection = new List<T>(elements);
        }

        public bool Move()
        {
            if (index == collection.Count - 1)
            {
                return false;
            }

            index++;
            return true;
        }

        public bool HasNext()
        {
            if (Move())
            {
                index--;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(collection[index]);
        }

        public void PrintAll()
        {
            if (collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
