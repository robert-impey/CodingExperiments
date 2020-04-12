using FluentAssertions;

namespace Cache.Test
{
    internal class NoEvictionsTests
    {
        private readonly IIntCache _cache;

        public NoEvictionsTests(IIntCache cache)
        {
            _cache = cache;
        }

        public void Test()
        {
            TestGetFromEmpty();
            GetValue();
            GetMissingValue();
        }
        
        private void TestGetFromEmpty()
        {
            var got = _cache.Get(1);

            got.Should().Be(-1);
        }
        
        private void GetValue()
        {
            _cache.Put(1, 1);

            var got = _cache.Get(1);

            got.Should().Be(1);
        }
        
        private void GetMissingValue()
        {
            _cache.Put(1, 1);

            var got = _cache.Get(2);

            got.Should().Be(-1);
        }
    }
}