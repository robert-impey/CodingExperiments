using System;
using FluentAssertions;

namespace Cache.Test
{
    internal class LruEvictionsTests
    {
        private readonly Func<int, ILruCache> _getCache;

        public LruEvictionsTests(Func<int, ILruCache> getCache)
        {
            _getCache = getCache;
        }

        public void Test()
        {
            GetAfterEvictionsWithoutPreviousGet();
            GetAfterEvictionsWithPreviousGet();
        }

        private void GetAfterEvictionsWithoutPreviousGet()
        {
            var cache = _getCache(2);

            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3); // This should evict 1

            cache.Get(1).Should().Be(-1);
            cache.Get(2).Should().Be(2);
            cache.Get(3).Should().Be(3);
        }

        private void GetAfterEvictionsWithPreviousGet()
        {
            var cache = _getCache(2);

            cache.Put(1, 1);
            cache.Put(2, 2);

            var got = cache.Get(1); // 2 is now the least recently used

            cache.Put(3, 3); // This should evict 2

            cache.Get(1).Should().Be(1);
            cache.Get(2).Should().Be(-1);
            cache.Get(3).Should().Be(3);
        }
    }
}