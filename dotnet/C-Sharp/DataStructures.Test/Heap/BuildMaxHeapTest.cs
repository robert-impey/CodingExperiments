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
            var array = new int[] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            TestBuilding(array);
        }

        [Fact]
        public void BuildRandomMaxHeap()
        {
            var rand = new Random();

            for (var j = 0; j < 100; j++)
            {
                var array = new int[1000];

                for (var i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(10000);
                }

                TestBuilding(array);
            }
        }

        private static void TestBuilding(int[] array)
        {
            var heap = new DataStructures.Heap(array);

            heap.BuildMaxHeap();

            heap.IsMaxHeap().Should().BeTrue();
        }
    }
}