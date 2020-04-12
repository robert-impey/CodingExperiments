using System;
using FluentAssertions;
using Xunit;

namespace Cache.Test
{
    public class LruCacheTest
    {
        [Fact]
        public void GetFromEmpty()
        {
            var cache = new LruCache(1);

            var got = cache.Get(1);

            got.Should().Be(-1);
        }

        [Fact]
        public void GetValue()
        {
            var cache = new LruCache(1);
            
            cache.Put(1, 1);

            var got = cache.Get(1);

            got.Should().Be(1);
        }

        [Fact]
        public void GetMissingValue()
        {
            var cache = new LruCache(1);
            
            cache.Put(1, 1);

            var got = cache.Get(2);

            got.Should().Be(-1);
        }

        [Fact]
        public void GetAfterEvictionsWithoutPreviousGet()
        {
            var cache = new LruCache(2);
            
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3); // This should evict 1

            cache.Get(1).Should().Be(-1);
            cache.Get(2).Should().Be(2);
            cache.Get(3).Should().Be(3);
        }

        [Fact]
        public void GetAfterEvictionsWithPreviousGet()
        {
            var cache = new LruCache(2);
            
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