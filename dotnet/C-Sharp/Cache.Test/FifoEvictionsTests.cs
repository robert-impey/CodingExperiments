using System;
using FluentAssertions;

namespace Cache.Test
{
    internal class FifoEvictionsTests
    {
        private readonly Func<int, IFifoCache> _getCache;

        public FifoEvictionsTests(Func<int, IFifoCache> getCache)
        {
            _getCache = getCache;
        }

        public void Test()
        {
            GetAfterEviction();
            GetAfterOverwriteAndEviction();
        }

        private void GetAfterEviction()
        {
            var cache = _getCache(2);

            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3); // This should evict 1

            cache.Get(1).Should().Be(-1);
            cache.Get(2).Should().Be(2);
            cache.Get(3).Should().Be(3);
        }

        private void GetAfterOverwriteAndEviction()
        {
            var cache = _getCache(2);

            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(1, 11);
            cache.Put(3, 3); // This should evict 2

            cache.Get(1).Should().Be(11);
            cache.Get(2).Should().Be(-1);
            cache.Get(3).Should().Be(3);
        }
    }
}