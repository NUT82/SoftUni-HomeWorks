using System.Collections.Generic;

namespace CollectionHierarchy.Contracts
{
    public interface ICollection
    {
        const int length = 100;
        public IEnumerable<string> MyCollection { get; }

        public int[] Add(params string[] elements);
    }
}
