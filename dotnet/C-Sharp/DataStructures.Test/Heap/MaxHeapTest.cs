using FluentAssertions;
using Xunit;

namespace DataStructures.Test.Heap
{
    public class MaxHeapTest
    {
        [Fact]
        public void Empty()
        {
            var heap = new DataStructures.Heap(System.Array.Empty<int>());
            heap.IsMaxHeap().Should().BeTrue();
        }

        [Fact]
        public void Single()
        {
            var heap = new DataStructures.Heap(new int[] { 1 });
            heap.IsMaxHeap().Should().BeTrue();
        }

        [Fact]
        public void NonMaxHeap()
        {
            var heap = new DataStructures.Heap(new int[] { 1, 2 });
            heap.IsMaxHeap().Should().BeFalse();
        }

        [Fact]
        public void ManyItemsMaxHeap()
        {
            var heap = new DataStructures.Heap(new int[] { 23, 17, 14, 6, 13, 10, 1, 5, 4, 12 });
            heap.IsMaxHeap().Should().BeTrue();
        }

        [Fact]
        public void ManyItemsNonMaxHeap()
        {
            var heap = new DataStructures.Heap(new int[] { 23, 17, 14, 6, 13, 10, 1, 5, 7, 12 });
            heap.IsMaxHeap().Should().BeFalse();
        }
    }
}