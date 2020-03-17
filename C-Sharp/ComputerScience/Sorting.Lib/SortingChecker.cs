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

            var arrayForComparing1 = new int[array1.Length];
            Array.Copy(array1, 0, arrayForComparing1, 0, array1.Length);

            var arrayForComparing2 = new int[array2.Length];
            Array.Copy(array2, 0, arrayForComparing2, 0, array2.Length);

            Array.Sort(arrayForComparing1);
            Array.Sort(arrayForComparing2);

            for (var i = 0; i < arrayForComparing1.Length; i++)
            {
                if (arrayForComparing1[i] != arrayForComparing2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}