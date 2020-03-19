using FluentAssertions;
using Xunit;

namespace DataStructures.Test
{
    public class MaxHeapTest
    {
        [Fact]
        public void Empty()
        {
            Heap.IsMaxHeap(System.Array.Empty<int>()).Should().BeTrue();
        }

        [Fact]
        public void Single()
        {
            Heap.IsMaxHeap(new int[] { 1 }).Should().BeTrue();
        }

        [Fact]
        public void NonMaxHeap()
        {
            Heap.IsMaxHeap(new int[] { 1 , 2 }).Should().BeFalse();
        }

        [Fact]
        public void ManyItemsMaxHeap()
        {
            var heapAry = new int[] { 23, 17, 14, 6, 13, 10, 1, 5, 7, 12 };
            Heap.IsMaxHeap(heapAry).Should().BeTrue();
        }

        [Fact]
        public void ManyItemsNonMaxHeap()
        {
            var heapAry = new int[] { 23, 17, 14, 6, 13, 10, 1, 5, 7, 12, 14 };
            Heap.IsMaxHeap(heapAry).Should().BeFalse();
        }
    }
}