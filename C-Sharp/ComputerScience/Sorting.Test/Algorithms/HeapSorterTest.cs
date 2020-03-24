using Sorting.Lib.Algorithms;
using Xunit;

namespace Sorting.Test.Algorithms
{
    public class HeapSorterTest
    {
        [Fact]
        public void ShouldSort()
        {
            AlgorithmChecker.TestSorter(new HeapSorter());
        }
    }
}