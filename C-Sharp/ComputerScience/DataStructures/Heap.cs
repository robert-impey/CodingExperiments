using System;

namespace DataStructures
{
    public class Heap
    {
        private readonly int[] _heap;

        public Heap(int[] input)
        {
            _heap = new int[input.Length + 1];

            Array.Copy(input, 0, _heap, 1, input.Length);
        }

        public bool IsMaxHeap()
        {
            for (var i = _heap.Length - 1; i >= 2; i--)
            {
                if (_heap[i] > _heap[GetParentIndex(i)])
                {
                    return false;
                }
            }

            return true;
        }

        private static int GetParentIndex(int index)
        {
            return index / 2;
        }

        private static int GetLeftIndex(int index)
        {
            return 2 * index;
        }

        private static int GetRightIndex(int index)
        {
            return (2 * index) + 1;
        }

        public void MaxHeapify(int index)
        {
            var l = GetLeftIndex(index);
            var r = GetRightIndex(index);

            var largest = (l < _heap.Length && _heap[l] > _heap[index]) ? l : index;

            if (r < _heap.Length && _heap[r] > _heap[largest])
            {
                largest = r;
            }

            if (largest != index)
            {
                Swapper.Swap(_heap, index, largest);
                MaxHeapify(largest);
            }
        }

        public void BuildMaxHeap()
        {
            for (var i = _heap.Length / 2; i >= 1; i--)
            {
                MaxHeapify(i);
            }
        }

        public int[] ToArray()
        {
            var array = new int[_heap.Length - 1];

            Array.Copy(_heap, 1, array, 0, array.Length);

            return array;
        }
    }
}