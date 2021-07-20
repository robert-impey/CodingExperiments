using DataStructures;

namespace Sorting.Lib.Algorithms
{
    public class HeapSorter : IIntSorter
    {
        public int[] Sort(int[] items)
        {
            var heap = new Heap(items);

            heap.Sort();

            return heap.ToArray();
        }
    }
}