using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
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
    }
}
