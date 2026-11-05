using System.Collections.Generic;

namespace Sorting.Lib
{
    public static class SortedMerger
    {
        public static LinkedList<int> Merge(LinkedList<int> left, LinkedList<int> right)
        {
            var accumulator = new LinkedList<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left.First.Value < right.First.Value)
                {
                    accumulator.AddLast(left.First.Value);
                    left.RemoveFirst();
                }
                else
                {
                    accumulator.AddLast(right.First.Value);
                    right.RemoveFirst();
                }
            }

            while (left.Count > 0)
            {
                accumulator.AddLast(left.First.Value);
                left.RemoveFirst();
            }

            while (right.Count > 0)
            {
                accumulator.AddLast(right.First.Value);
                right.RemoveFirst();
            }

            return accumulator;
        }
    }
}