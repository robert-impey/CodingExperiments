using System.Collections;
using System.Collections.Generic;

namespace EnumerableCounting
{
    class CountUpSequence : IEnumerable<int>
    {
        private readonly int max;

        internal CountUpSequence(int max)
        {
            this.max = max;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new CountUpEnumerator(max);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
