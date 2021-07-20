using System;

namespace Cache.Test
{
    internal class FifoCacheTest
    {
        private readonly Func<int, IFifoCache> _getCache;

        public FifoCacheTest(Func<int, IFifoCache> getCache)
        {
            _getCache = getCache;
        }

        public void Test()
        {
            NoEvictionsTests();
            EvictionsTests();
        }

        private void NoEvictionsTests()
        {
            var noEvictionsTest = new NoEvictionsTests(_getCache);

            noEvictionsTest.Test();
        }

        private void EvictionsTests()
        {
            var evictionsTests = new FifoEvictionsTests(_getCache);

            evictionsTests.Test();
        }
    }
}