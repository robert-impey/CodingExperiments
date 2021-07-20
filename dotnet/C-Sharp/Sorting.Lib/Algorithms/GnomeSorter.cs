namespace Sorting.Lib.Algorithms
{
    // https://en.wikipedia.org/wiki/Gnome_sort
    public class GnomeSorter : IIntSorter
    {
        public int[] Sort(int[] items)
        {
            var pos = 0;
            while (pos < items.Length)
            {
                if (pos == 0 || items[pos] >= items[pos - 1])
                {
                    pos++;
                }
                else
                {
                    DataStructures.Swapper.Swap(items, pos, pos - 1);
                    pos--;
                }
            }

            return items;
        }
    }
}