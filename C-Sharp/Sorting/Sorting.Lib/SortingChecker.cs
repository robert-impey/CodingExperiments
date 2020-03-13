using System;

namespace Sorting.Lib
{
    public class SortingChecker
    {
        public static bool IsInOrder(int[] ary)
        {
            for (var i = 1; i < ary.Length; i++)
            {
                if (ary[i - 1] > ary[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ArePermutations(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
            {
                return false;
            }

            if (array1.Length != array2.Length)
            {
                return false;
            }

            Array.Sort(array1);
            Array.Sort(array2);

            for (var i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}