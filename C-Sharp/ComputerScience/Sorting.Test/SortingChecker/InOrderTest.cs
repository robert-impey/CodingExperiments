using FluentAssertions;
using Xunit;

namespace Sorting.Test
{
    public class InOrderTest
    {
        [Fact]
        public void TestEmpty()
        {
            Lib.SortingChecker.IsInOrder(new int[0]).Should().BeTrue();
        }

        [Fact]
        public void TestSingle()
        {
            Lib.SortingChecker.IsInOrder(new int[] { 1 }).Should().BeTrue();
        }

        [Fact]
        public void TestAscending()
        {
            Lib.SortingChecker.IsInOrder(new int[] { 1, 2, 3 }).Should().BeTrue();
        }

        [Fact]
        public void TestRepeated()
        {
            Lib.SortingChecker.IsInOrder(new int[] { 1, 1, 1 }).Should().BeTrue();
        }

        [Fact]
        public void TestOutOfOrder()
        {
            Lib.SortingChecker.IsInOrder(new int[] { 2, 1, 3 }).Should().BeFalse();
        }
    }
}