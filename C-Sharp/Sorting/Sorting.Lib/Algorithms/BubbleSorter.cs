namespace Sorting.Lib.Algorithms
{
    public class BubbleSorter : IIntSorter
    {
        public int[] Sort(int[] items)
        {
            while (true)
            {
                var swapped = false;
                for (var j = 1; j < items.Length; j++)
                {
                    var i = j - 1;
                    if (items[i] > items[j])
                    {
                        Swapper.Swap(items, i, j);

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }

            return items;
        }
    }
}