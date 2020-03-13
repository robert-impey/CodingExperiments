using FluentAssertions;
using Xunit;

namespace Sorting.Test.SortingChecker
{
    public class ArePermutationsTest
    {
        [Fact]
        public void EmptyArrays()
        {
            Lib.SortingChecker.ArePermutations(new int[0], new int[0]).Should().BeTrue();
        }

        [Fact]
        public void SingleSameElement()
        {
            Lib.SortingChecker.ArePermutations(new int[] { 1 }, new int[] { 1 }).Should().BeTrue();
        }

        [Fact]
        public void SingleDifferentElement()
        {
            Lib.SortingChecker.ArePermutations(new int[] { 1 }, new int[] { 2 }).Should().BeFalse();
        }

        [Fact]
        public void DifferentLength()
        {
            Lib.SortingChecker.ArePermutations(new int[] { 1 }, new int[0]).Should().BeFalse();
        }

        [Fact]
        public void SameElementsDifferentOrder()
        {
            Lib.SortingChecker.ArePermutations(new int[] { 1, 2, 3 }, new int[] { 2, 1, 3 }).Should().BeTrue();
        }

        [Fact]
        public void NullsAreDifferent()
        {
            Lib.SortingChecker.ArePermutations(null, null).Should().BeFalse();
        }
    }
}