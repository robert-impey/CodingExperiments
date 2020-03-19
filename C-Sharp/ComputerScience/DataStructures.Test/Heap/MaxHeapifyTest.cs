using FluentAssertions;
using Xunit;

namespace DataStructures.Test.Heap
{
    public class MaxHeapifyTest
    {
        [Fact]
        public void ManyElements()
        {
            var array = new int[] { default, 16, 4, 10, 14, 7, 9, 3, 2, 8, 1 };

            DataStructures.Heap.MaxHeapify(array, 2);

            DataStructures.Heap.IsMaxHeap(array).Should().BeTrue();

            array[2].Should().Be(14);
            array[4].Should().Be(8);
            array[9].Should().Be(4);
        }
    }
}
