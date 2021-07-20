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

        [Fact]
        public void InputsAreNotChanged()
        {
            var input1 = new int[] { 2, 3, 1 };
            var input2 = new int[] { 3, 1, 2 };

            Lib.SortingChecker.ArePermutations(input1, input2);

            input1[0].Should().Be(2);
            input1[1].Should().Be(3);
            input1[2].Should().Be(1);

            input2[0].Should().Be(3);
            input2[1].Should().Be(1);
            input2[2].Should().Be(2);
        }
    }
}