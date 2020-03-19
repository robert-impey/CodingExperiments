namespace DataStructures
{
    public class Heap
    {
        public static bool IsMaxHeap(int[] array)
        {
            for (var i = array.Length - 1; i >= 2; i--)
            {
                if (array[i] > array[GetParentIndex(i)])
                {
                    return false;
                }
            }

            return true;
        }

        public static int GetParentIndex(int index)
        {
            return index / 2;
        }

        public static int GetLeftIndex(int index)
        {
            return 2 * index;
        }

        public static int GetRightIndex(int index)
        {
            return (2 * index) + 1;
        }

        public static void MaxHeapify(int[] array, int index)
        {
            var l = GetLeftIndex(index);
            var r = GetRightIndex(index);

            var largest = (l < array.Length && array[l] > array[index]) ? l : index;

            if (r <= array.Length && array[r] > array[largest])
            {
                largest = r;
            }

            if (largest != index)
            {
                Swapper.Swap(array, index, largest);
                MaxHeapify(array, largest);
            }
        }
    }
}