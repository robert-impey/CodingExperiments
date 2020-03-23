using FluentAssertions;
using System;
using Xunit;

namespace DataStructures.Test.Heap
{
    public class BuildMaxHeapTest
    {
        [Fact]
        public void BuildMaxHeap()
        {
            var array = new int[] { default, 5, 3, 17, 10, 84, 19, 6, 22, 9 };
            
            TestBuilding(array);
        }

        [Fact]
        public void BuildRandomMaxHeap()
        {
            var rand = new Random();

            var array = new int[1000];

            for (var i = 1; i < array.Length; i++)
            {
                array[i] = rand.Next(10000);
            }

            TestBuilding(array);
        }

        private static void TestBuilding(int[] array)
        {
            DataStructures.Heap.BuildMaxHeap(array);

            DataStructures.Heap.IsMaxHeap(array).Should().BeTrue();
        }
    }
}