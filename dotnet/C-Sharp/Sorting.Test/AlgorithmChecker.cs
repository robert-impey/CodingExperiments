using Sorting.Lib;
using System;
using Shouldly;

namespace Sorting.Test;

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
        var sorted = intSorter.Sort([]);

        sorted.Length.ShouldBe(0);
    }

    private static void SingleItem(IIntSorter intSorter)
    {
        var sorted = intSorter.Sort([1]);

        sorted.Length.ShouldBe(1);
        sorted[0].ShouldBe(1);
    }

    private static void SameLength(IIntSorter intSorter)
    {
        var inputArray = new[] { 2, 1, 3 };
        var arrayForSorting = new int[inputArray.Length];

        Array.Copy(inputArray, 0, arrayForSorting, 0, inputArray.Length);

        var sorted = intSorter.Sort(arrayForSorting);

        sorted.Length.ShouldBe(inputArray.Length);
    }

    private static void OutOfOrder(IIntSorter intSorter)
    {
        var input = MakeRandomArray();

        var sorted = intSorter.Sort(input);

        Lib.SortingChecker.IsInOrder(sorted).ShouldBeTrue();
    }

    private static void ArePermutations(IIntSorter intSorter)
    {
        var inputArray = MakeRandomArray();
        var arrayForSorting = new int[inputArray.Length];

        Array.Copy(inputArray, 0, arrayForSorting, 0, inputArray.Length);

        var sorted = intSorter.Sort(arrayForSorting);

        Lib.SortingChecker.ArePermutations(inputArray, sorted).ShouldBeTrue();
    }

    private static int[] MakeRandomArray(int size = 5, int range = 10)
    {
        var rand = new Random();

        var randArray = new int[size];

        for (var i = 0; i < size; i++)
        {
            randArray[i] = rand.Next(range);
        }

        return randArray;
    }
}