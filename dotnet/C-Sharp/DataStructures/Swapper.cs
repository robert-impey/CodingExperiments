namespace DataStructures
{ 
    public static class Swapper
    {
        public static void Swap(int[] ary, int firstIndex, int secondIndex)
        {
            (ary[firstIndex], ary[secondIndex]) = (ary[secondIndex], ary[firstIndex]);
        }
    }
}