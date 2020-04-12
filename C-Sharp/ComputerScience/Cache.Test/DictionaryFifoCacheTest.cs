using Xunit;

namespace Cache.Test
{
    public class DictionaryFifoCacheTest
    {
        [Fact]
        public void FifoTests()
        {
            var fifoCacheTest = new FifoCacheTest(c => new DictionaryFifoCache(c));

            fifoCacheTest.Test();
        }
    }
}