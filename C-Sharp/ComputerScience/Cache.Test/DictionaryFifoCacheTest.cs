using Xunit;

namespace Cache.Test
{
    public class DictionaryFifoCacheTest
    {
        [Fact]
        public void NoEvictionsTests()
        {
            var noEvictionsTest = new NoEvictionsTests(new DictionaryFifoCache(1));

            noEvictionsTest.Test();
        }
        
        
        [Fact]
        public void EvictionsTests()
        {
            var evictionsTests = new FifoEvictionsTests(new DictionaryFifoCache(2));
            
            evictionsTests.Test();
        }
    }
}