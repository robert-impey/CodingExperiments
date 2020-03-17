namespace Sorting.Lib.Algorithms
{
    public class SelectionSorter : IIntSorter
    {
        public int[] Sort(int[] items)
        {
            for (var i = 0; i < items.Length - 1; i++)
            {
                var minIndexInUnsorted = i;

                for (var j = i + 1; j < items.Length; j++)
                {
                    if (items[j] < items[minIndexInUnsorted])
                    {
                        minIndexInUnsorted = j;
                    }
                }

                if (minIndexInUnsorted != i)
                {
                    Swapper.Swap(items, i, minIndexInUnsorted);
                }
            }

            return items;
        }
    }
}