using Sorting.Lib.Algorithms;
using Xunit;

namespace Sorting.Test.Algorithms
{
    public class BubbleSorterTest
    {
        [Fact]
        public void ShouldSort()
        {
            AlgorithmChecker.TestSorter(new BubbleSorter());
        }
    }
}