namespace Sorting.Lib.Algorithms
{
    public class InsertionSorter : IIntSorter
    {
        public int[] Sort(int[] items)
        {
            for (var j = 1; j < items.Length; j++)
            {
                var key = items[j];

                for (var i = j - 1; i >= 0; i--)
                {
                    if (items[i] > key)
                    {
                        Swapper.Swap(items, i, i + 1);
                    }
                }
            }

            return items;
        }
    }
}