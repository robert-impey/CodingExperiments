using FluentAssertions;
using Xunit;

namespace DataStructures.Test.Heap
{
    public class MaxHeapifyTest
    {
        [Fact]
        public void ManyElements()
        {
            var array = new int[] { 16, 4, 10, 14, 7, 9, 3, 2, 8, 1 };

            var heap = new DataStructures.Heap(array);

            heap.MaxHeapify(2);

            heap.IsMaxHeap().Should().BeTrue();

            var heapArray = heap.ToArray();

            heapArray[1].Should().Be(14);
            heapArray[3].Should().Be(8);
            heapArray[8].Should().Be(4);
        }
    }
}
