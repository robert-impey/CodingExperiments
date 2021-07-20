using System;

namespace Cache.Test
{
    internal class LruCacheTest
    {
        private readonly Func<int, ILruCache> _getCache;

        public LruCacheTest(Func<int, ILruCache> getCache)
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
            var evictionsTests = new LruEvictionsTests(_getCache);

            evictionsTests.Test();
        }
    }
}