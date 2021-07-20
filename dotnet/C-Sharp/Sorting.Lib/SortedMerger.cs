using System.Collections.Generic;

namespace Sorting.Lib
{
    public static class SortedMerger
    {
        public static LinkedList<int> Merge(LinkedList<int> left, LinkedList<int> right)
        {
            LinkedList<int> MergeHelper(LinkedList<int> leftInner, LinkedList<int> rightInner, LinkedList<int> accumulator)
            {
                if (leftInner.Count > 0 && rightInner.Count > 0)
                {
                    if (leftInner.First.Value < rightInner.First.Value)
                    {
                        accumulator.AddLast(leftInner.First.Value);
                        leftInner.RemoveFirst();
                    }
                    else
                    {
                        accumulator.AddLast(rightInner.First.Value);
                        rightInner.RemoveFirst();
                    }

                    return MergeHelper(leftInner, rightInner, accumulator);
                }

                if (leftInner.Count > 0)
                {
                    accumulator.AddLast(leftInner.First.Value);
                    leftInner.RemoveFirst();

                    return MergeHelper(leftInner, rightInner, accumulator);
                }

                if (rightInner.Count > 0)
                {
                    accumulator.AddLast(rightInner.First.Value);
                    rightInner.RemoveFirst();

                    return MergeHelper(leftInner, rightInner, accumulator);
                }

                return accumulator;
            }

            return MergeHelper(left, right, new LinkedList<int>());
        }
    }
}