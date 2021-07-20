using Xunit;

namespace Cache.Test
{
    public class DictionaryLruCacheTest
    {
        [Fact]
        public void LruTests()
        {
            var lruCacheTest = new LruCacheTest(c => new DictionaryLruCache(c));

            lruCacheTest.Test();
        }
    }
}