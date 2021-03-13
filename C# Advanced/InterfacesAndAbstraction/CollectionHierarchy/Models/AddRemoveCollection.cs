using CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : ICollection, IRemoveCollection
    {
        private readonly Queue<string> myCollection;

        public AddRemoveCollection()
        {
            myCollection = new Queue<string>();
        }

        public IEnumerable<string> MyCollection => myCollection;

        public int[] Add(params string[] elements)
        {
            int[] result = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                myCollection.Enqueue(elements[i]);
            }

            return result;
        }

        public string Remove()
        {
            return myCollection.Dequeue();
        }
    }
}
