using System.Collections.Generic;
using System.Linq;

namespace Sorting.Lib.Algorithms
{
    public class TopDownListMergeSorter : IIntSorter
    {
        public int[] Sort(int[] items)
        {
            if (items.Length <= 1)
            {
                return items;
            }

            return Sort(new LinkedList<int>(items)).ToArray();
        }

        private LinkedList<int> Sort(LinkedList<int> items)
        {
            if (items.Count <= 1)
            {
                return items;
            }

            var left = new LinkedList<int>();
            var right = new LinkedList<int>();

            var counter = 0;
            foreach (var item in items)
            {
                if (counter < items.Count / 2)
                {
                    left.AddLast(item);
                }
                else
                {
                    right.AddLast(item);
                }
                counter++;
            }

            return SortedMerger.Merge(Sort(left), Sort(right));
        }
    }
}