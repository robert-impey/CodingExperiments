using System;

namespace DataStructures
{
    public class Heap
    {
        public static bool IsMaxHeap(int[] ary)
        {
            var oneBassedArray = new int[ary.Length + 1];

            Array.Copy(ary, 0, oneBassedArray, 1, ary.Length);

            for (var i = oneBassedArray.Length - 1; i >= 2; i--)
            {
                if (oneBassedArray[i] > oneBassedArray[GetParentIndex(oneBassedArray, i)])
                {
                    return false;
                }
            }

            return true;
        }

        public static int GetParentIndex(int[] heap, int index)
        {
            if (index < 1 || index > heap.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            return index / 2;
        }
    }
}