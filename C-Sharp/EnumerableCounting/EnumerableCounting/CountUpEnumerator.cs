using System.Collections;
using System.Collections.Generic;

namespace EnumerableCounting
{
    class CountUpEnumerator : IEnumerator<int>
    {
        private readonly int max;
        private int current;

        internal CountUpEnumerator(int max)
        {
            this.max = max;
            Reset();
        }

        public int Current
        {
            get
            {
                return current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            current++;
            return current < max;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}
