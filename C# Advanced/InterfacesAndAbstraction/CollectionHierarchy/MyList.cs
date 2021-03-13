using CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    public class MyList : IRemoveCollection
    {
        private readonly Stack<string> myCollection;

        public MyList()
        {
            myCollection = new Stack<string>();
        }

        public IEnumerable<string> MyCollection => myCollection;

        public int Used => myCollection.Count;

        public int[] Add(params string[] elements)
        {
            int[] result = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                myCollection.Push(elements[i]);
            }

            return result;
        }

        public string Remove()
        {
            return myCollection.Pop();
        }
    }
}
