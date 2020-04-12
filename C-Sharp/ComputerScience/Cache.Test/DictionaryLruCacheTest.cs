using System;
using FluentAssertions;
using Xunit;

namespace Cache.Test
{
    public class DictionaryLruCacheTest
    {
        [Fact]
        public void NoEvictionsTests()
        {
            var noEvictionsTest = new NoEvictionsTests(new DictionaryLruCache(1));

            noEvictionsTest.Test();
        }

        [Fact]
        public void EvictionsTests()
        {
            var evictionsTests = new LruEvictionsTests(new DictionaryLruCache(2));
            
            evictionsTests.Test();
        }
    }
}