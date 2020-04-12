using FluentAssertions;

namespace Cache.Test
{
    internal class LruEvictionsTests
    {
        private readonly ILruCache _cache;

        public LruEvictionsTests(ILruCache cache)
        {
            _cache = cache;
        }

        public void Test()
        {
            GetAfterEvictionsWithoutPreviousGet();
            GetAfterEvictionsWithPreviousGet();
        }

        private void GetAfterEvictionsWithoutPreviousGet()
        {
            _cache.Put(1, 1);
            _cache.Put(2, 2);
            _cache.Put(3, 3); // This should evict 1

            _cache.Get(1).Should().Be(-1);
            _cache.Get(2).Should().Be(2);
            _cache.Get(3).Should().Be(3);
        }

        private void GetAfterEvictionsWithPreviousGet()
        {
            _cache.Put(1, 1);
            _cache.Put(2, 2);

            var got = _cache.Get(1); // 2 is now the least recently used
            
            _cache.Put(3, 3); // This should evict 2

            _cache.Get(1).Should().Be(1);
            _cache.Get(2).Should().Be(-1);
            _cache.Get(3).Should().Be(3);
        }
    }
}