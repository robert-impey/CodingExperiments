using FluentAssertions;
using Xunit;

namespace DataStructures.Test
{
    public class GetParentIndexTest
    {
        [Fact]
        public void GetParentIndexOfRoot()
        {
            var heap = new int[] { default, 1 };

            Heap.GetParentIndex(heap, 1).Should().Be(default);
        }

        [Fact]
        public void GetParentOfLeft()
        {
            var heap = new int[] { default, 3, 1 };

            Heap.GetParentIndex(heap, 2).Should().Be(1);
        }

        [Fact]
        public void GetParentOfRight()
        {
            var heap = new int[] { default, 3, 1, 2 };

            Heap.GetParentIndex(heap, 3).Should().Be(1);
        }
    }
}