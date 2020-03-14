using Sorting.Lib.Algorithms;
using Xunit;

namespace Sorting.Test.Algorithms
{
    public class SelectionSorterTest
    {
        [Fact]
        public void ShouldSort()
        {
            AlgorithmChecker.TestSorter(new SelectionSorter());
        }
    }
}