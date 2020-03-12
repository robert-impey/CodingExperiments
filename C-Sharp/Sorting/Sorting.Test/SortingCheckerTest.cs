using FluentAssertions;
using Sorting.Lib;
using Xunit;

namespace Sorting.Test
{
    public class SortingCheckerTest
    {
        [Fact]
        public void TestEmpty()
        {
            SortingChecker.IsInOrder(new int[0]).Should().BeTrue();
        }

        [Fact]
        public void TestSingle()
        {
            SortingChecker.IsInOrder(new int[] { 1 }).Should().BeTrue();
        }

        [Fact]
        public void TestAscending()
        {
            SortingChecker.IsInOrder(new int[] { 1, 2, 3 }).Should().BeTrue();
        }

        [Fact]
        public void TestRepeated()
        {
            SortingChecker.IsInOrder(new int[] { 1, 1, 1 }).Should().BeTrue();
        }

        [Fact]
        public void TestOutOfOrder()
        {
            SortingChecker.IsInOrder(new int[] { 2, 1, 3 }).Should().BeFalse();
        }
    }
}