using Sorting.Lib.Algorithms;
using Xunit;

namespace Sorting.Test.Algorithms
{
    public class TopDownListMergeSorterTest
    {
        [Fact]
        public void ShouldSort()
        {
            AlgorithmChecker.TestSorter(new TopDownListMergeSorter());
        }
    }
}