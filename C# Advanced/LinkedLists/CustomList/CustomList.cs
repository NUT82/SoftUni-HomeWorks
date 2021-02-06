using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    class CustomList
    {
        private const int InitialCapacity = 2;

        public CustomList()
        {
            int[] Items = new int[InitialCapacity];
        }
        public int[] Items { get; set; }

        public int Count { get; set; }

        public int this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return Items[index];
            }
            set
            {
                if (index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Items[index] = value;
            }
        }

        private void Resize()
        {
            int[] newArray = new int[Items.Length * 2];
            newArray = Items.ToArray();
            Items = newArray;
        }

        private void Shrink()
        {
            int[] newArray = new int[Items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = Items[i];
            }
            Items = newArray;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                Items[i] = Items[i + 1];
            }
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                Items[i] = Items[i - 1];
            }
        }

        public void Add(int number)
        {
            if (Items.Length == Count)
            {
                Resize();
            }

            Items[Count] = number;
            Count++;
        }

        public void Insert(int index, int number)
        {
            if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (Items.Length == Count)
            {
                Resize();
            }
            ShiftToRight(index);
            Items[index] = number;
            Count++;
        }

        public int RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int number = Items[index];
            Shift(index);
            Count--;

            if (Count <= Items.Length / 4)
            {
                Shrink();
            }

            return number;
        }

        public bool Contains(int number)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Items[i] == number)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex >= Count || firstIndex < 0 || secondIndex >= Count || secondIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int temp = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = temp;
        }
    }
}
