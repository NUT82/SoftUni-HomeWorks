using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            List = new List<T>();
        }
        public List<T> List { get; set; }

        public int Count { get { return List.Count; } }

        public void Add(T element)
        {
            List.Add(element);
        }

        public T Remove()
        {
            if (Count == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            T element = List[Count - 1];
            List.RemoveAt(Count - 1);
            return element;
        }
    }
}
