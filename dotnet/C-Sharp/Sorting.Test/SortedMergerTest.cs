using Sorting.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;

namespace Sorting.Test;

public class SortedMergerTest
{
    [Fact]
    public void EmtpyLists()
    {
        var merged = SortedMerger.Merge(new LinkedList<int>(), new LinkedList<int>());
        merged.Count.ShouldBe(0);
    }

    [Fact]
    public void JustLeft()
    {
        var singleItem = new LinkedList<int>();
        singleItem.AddFirst(714);
        var merged = SortedMerger.Merge(singleItem, new LinkedList<int>());
        merged.Count.ShouldBe(1);
        merged.First.Value.ShouldBe(714);
    }

    [Fact]
    public void JustRight()
    {
        var singleItem = new LinkedList<int>();
        singleItem.AddFirst(714);
        var merged = SortedMerger.Merge(new LinkedList<int>(), singleItem);
        merged.Count.ShouldBe(1);
        merged.First.Value.ShouldBe(714);
    }

    [Fact]
    public void SortedLists()
    {
        var left = new LinkedList<int>();
        left.AddFirst(42);
        var right = new LinkedList<int>();
        right.AddFirst(714);
        var merged = SortedMerger.Merge(left, right);
        merged.Count.ShouldBe(2);
        merged.First.Value.ShouldBe(42);
        merged.Last.Value.ShouldBe(714);
    }

    [Fact]
    public void SortedListsRightFirst()
    {
        var left = new LinkedList<int>();
        left.AddFirst(714);
        var right = new LinkedList<int>();
        right.AddFirst(42);
        var merged = SortedMerger.Merge(left, right);
        merged.Count.ShouldBe(2);
        merged.First.Value.ShouldBe(42);
        merged.Last.Value.ShouldBe(714);
    }

    [Fact]
    public void SortedListsLongRandom()
    {
        LinkedList<int> MakeLongRandomAscendingList(int count, int range)
        {
            var longRandom = new LinkedList<int>();

            var rand = new Random();
            var previous = 0;
            for (var i = 0; i < count; i++)
            {
                var current = previous + rand.Next(range);
                longRandom.AddLast(current);
                previous = current;
            }

            return longRandom;
        }

        var count = 1000;
        var left = MakeLongRandomAscendingList(count, 10);
        var right = MakeLongRandomAscendingList(count, 10);

        var merged = SortedMerger.Merge(left, right);

        merged.Count.ShouldBe(count * 2);

        Lib.SortingChecker.IsInOrder(merged.ToArray()).ShouldBeTrue();
    }
}