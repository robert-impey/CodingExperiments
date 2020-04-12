using FluentAssertions;

namespace Cache.Test
{
    internal class FifoEvictionsTests
    {
        private readonly IFifoCache _cache;

        public FifoEvictionsTests(IFifoCache cache)
        {
            _cache = cache;
        }

        public void Test()
        {
            GetAfterEviction();
            GetAfterOverwriteAndEviction();
        }
        
        private void GetAfterEviction()
        {
            _cache.Put(1, 1);
            _cache.Put(2, 2);
            _cache.Put(3, 3); // This should evict 1

            _cache.Get(1).Should().Be(-1);
            _cache.Get(2).Should().Be(2);
            _cache.Get(3).Should().Be(3);
        }
        
        private void GetAfterOverwriteAndEviction()
        {
            _cache.Put(1, 1);
            _cache.Put(2, 2);
            _cache.Put(1, 11);
            _cache.Put(3, 3); // This should evict 2

            _cache.Get(1).Should().Be(11);
            _cache.Get(2).Should().Be(-1);
            _cache.Get(3).Should().Be(3);
        }
    }
}