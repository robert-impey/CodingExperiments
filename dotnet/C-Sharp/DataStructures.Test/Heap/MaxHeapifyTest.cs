using Shouldly;
using Xunit;

namespace DataStructures.Test.Heap;

public class MaxHeapifyTest
{
    [Fact]
    public void ManyElements()
    {
        var array = new[] { 16, 4, 10, 14, 7, 9, 3, 2, 8, 1 };

        var heap = new DataStructures.Heap(array);

        heap.MaxHeapify(2);

        heap.IsMaxHeap().ShouldBeTrue();

        var heapArray = heap.ToArray();

        heapArray[1].ShouldBe(14);
        heapArray[3].ShouldBe(8);
        heapArray[8].ShouldBe(4);
    }

    [Fact]
    public void LeaveTailAlone()
    {
        var array = new[] { 16, 4, 10, 14, 7, 17 };

        var heap = new DataStructures.Heap(array);

        heap.MaxHeapify(2, 5);

        heap.IsMaxHeap().ShouldBeFalse();

        var heapArray = heap.ToArray();

        heapArray[1].ShouldBe(14);
        heapArray[5].ShouldBe(17);
    }
}