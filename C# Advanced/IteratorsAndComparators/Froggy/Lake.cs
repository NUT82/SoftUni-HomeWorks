using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(IEnumerable<int> stones)
        {
            this.stones = stones.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i+= 2)
            {
                yield return stones[i];
            }
            for (int i = stones.Count - 1 - (stones.Count % 2); i >= 0; i-= 2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
