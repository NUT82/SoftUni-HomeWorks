using CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;

namespace CollectionHierarchy.Models
{
    public class AddCollection : ICollection
    {
        private readonly List<string> myCollection;

        public AddCollection()
        {
            myCollection = new List<string>();
        }
        public IEnumerable<string> MyCollection => myCollection.AsReadOnly();

        public int[] Add(params string[] elements)
        {
            int[] result = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                myCollection.Add(elements[i]);
                result[i] = i;
            }

            return result;
        }
    }
}
