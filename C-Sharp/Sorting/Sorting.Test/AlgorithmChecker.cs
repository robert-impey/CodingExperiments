using FluentAssertions;
using Sorting.Lib;
using System;

namespace Sorting.Test
{
    internal static class AlgorithmChecker
    {
        public static void TestSorter(IIntSorter intSorter)
        {
            TestEmptyArray(intSorter);
            SingleItem(intSorter);
            SameLength(intSorter);
            OutOfOrder(intSorter);
            ArePermutations(intSorter);
        }

        private static void TestEmptyArray(IIntSorter intSorter)
        {
            var sorted = intSorter.Sort(new int[0]);

            sorted.Length.Should().Be(0);
        }

        private static void SingleItem(IIntSorter intSorter)
        {
            var sorted = intSorter.Sort(new int[] { 1 });

            sorted.Length.Should().Be(1);
            sorted[0].Should().Be(1);
        }

        private static void SameLength(IIntSorter intSorter)
        {
            var inputArray = new int[] { 2, 1, 3 };
            var arrayForSorting = new int[inputArray.Length];

            Array.Copy(inputArray, 0, arrayForSorting, 0, inputArray.Length);

            var sorted = intSorter.Sort(arrayForSorting);

            sorted.Length.Should().Be(inputArray.Length);
        }

        private static void OutOfOrder(IIntSorter intSorter)
        {
            var sorted = intSorter.Sort(new int[] { 2, 1, 3 });

            Lib.SortingChecker.IsInOrder(sorted).Should().BeTrue();
        }

        private static void ArePermutations(IIntSorter intSorter)
        {
            var inputArray = new int[] { 2, 1, 3 };
            var arrayForSorting = new int[inputArray.Length];

            Array.Copy(inputArray, 0, arrayForSorting, 0, inputArray.Length);

            var sorted = intSorter.Sort(arrayForSorting);

            Lib.SortingChecker.ArePermutations(inputArray, sorted).Should().BeTrue();
        }
    }
}