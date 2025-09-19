using Shouldly;
using Xunit;

namespace DataStructures.Test.Heap;

public class MaxHeapTest
{
    [Fact]
    public void Empty()
    {
        var heap = new DataStructures.Heap([]);
        heap.IsMaxHeap().ShouldBeTrue();
    }

    [Fact]
    public void Single()
    {
        var heap = new DataStructures.Heap([1]);
        heap.IsMaxHeap().ShouldBeTrue();
    }

    [Fact]
    public void NonMaxHeap()
    {
        var heap = new DataStructures.Heap([1, 2]);
        heap.IsMaxHeap().ShouldBeFalse();
    }

    [Fact]
    public void ManyItemsMaxHeap()
    {
        var heap = new DataStructures.Heap([23, 17, 14, 6, 13, 10, 1, 5, 4, 12]);
        heap.IsMaxHeap().ShouldBeTrue();
    }

    [Fact]
    public void ManyItemsNonMaxHeap()
    {
        var heap = new DataStructures.Heap([23, 17, 14, 6, 13, 10, 1, 5, 7, 12]);
        heap.IsMaxHeap().ShouldBeFalse();
    }
}