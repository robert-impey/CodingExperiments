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
    }
}