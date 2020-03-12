using FluentAssertions;
using Sorting.Lib;
using Xunit;

namespace Sorting.Test
{
    public class BubbleSortTest
    {
        [Fact]
        public void TestEmptyArray()
        {
            var sorted = new BubbleSorter().Sort(new int[0]);

            sorted.Length.Should().Be(0);
        }
    }
}