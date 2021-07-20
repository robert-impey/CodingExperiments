using System;
using FluentAssertions;

namespace Cache.Test
{
    internal class NoEvictionsTests
    {
        private readonly Func<int, IIntCache> _getCache;

        public NoEvictionsTests(Func<int, IIntCache> getCache)
        {
            _getCache = getCache;
        }

        public void Test()
        {
            TestGetFromEmpty();
            GetValue();
            GetMissingValue();
        }

        private void TestGetFromEmpty()
        {
            var cache = _getCache(1);
            var got = cache.Get(1);

            got.Should().Be(-1);
        }

        private void GetValue()
        {
            var cache = _getCache(1);

            cache.Put(1, 1);

            var got = cache.Get(1);

            got.Should().Be(1);
        }

        private void GetMissingValue()
        {
            var cache = _getCache(1);

            cache.Put(1, 1);

            var got = cache.Get(2);

            got.Should().Be(-1);
        }
    }
}