using FluentAssertions;
using Xunit;

namespace DataStructures.Test.Heap
{
    public class MaxHeapTest
    {
        [Fact]
        public void Empty()
        {
            DataStructures.Heap.IsMaxHeap(new int[] { default }).Should().BeTrue();
        }

        [Fact]
        public void Single()
        {
            DataStructures.Heap.IsMaxHeap(new int[] { default, 1 }).Should().BeTrue();
        }

        [Fact]
        public void NonMaxHeap()
        {
            DataStructures.Heap.IsMaxHeap(new int[] { default, 1, 2 }).Should().BeFalse();
        }

        [Fact]
        public void ManyItemsMaxHeap()
        {
            var heapAry = new int[] { default, 23, 17, 14, 6, 13, 10, 1, 5, 4, 12 };
            DataStructures.Heap.IsMaxHeap(heapAry).Should().BeTrue();
        }

        [Fact]
        public void ManyItemsNonMaxHeap()
        {
            var heapAry = new int[] { default, 23, 17, 14, 6, 13, 10, 1, 5, 7, 12 };
            DataStructures.Heap.IsMaxHeap(heapAry).Should().BeFalse();
        }
    }
}