using FluentAssertions;
using Sorting.Lib;
using System;
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

        [Fact]
        public void SingleItem()
        {
            var sorted = new BubbleSorter().Sort(new int[] { 1 });

            sorted.Length.Should().Be(1);
            sorted[0].Should().Be(1);
        }

        [Fact]
        public void OutOfOrder()
        {
            var sorted = new BubbleSorter().Sort(new int[] { 2, 1, 3 });

            Lib.SortingChecker.IsInOrder(sorted).Should().BeTrue();
        }

        [Fact]
        public void SameLength()
        {
            var inputArray = new int[] { 2, 1, 3 };
            var arrayForSorting = new int[inputArray.Length];

            Array.Copy(inputArray, 0, arrayForSorting, 0, inputArray.Length);

            var sorted = new BubbleSorter().Sort(arrayForSorting);

            sorted.Length.Should().Be(inputArray.Length);
        }

        [Fact]
        public void ArePermutations()
        {
            var inputArray = new int[] { 2, 1, 3 };
            var arrayForSorting = new int[inputArray.Length];

            Array.Copy(inputArray, 0, arrayForSorting, 0, inputArray.Length);

            var sorted = new BubbleSorter().Sort(arrayForSorting);

            Lib.SortingChecker.ArePermutations(inputArray, sorted).Should().BeTrue();
        }
    }
}