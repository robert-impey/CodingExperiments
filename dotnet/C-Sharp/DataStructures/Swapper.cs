namespace DataStructures
{ 
    public static class Swapper
    {
        public static void Swap(int[] ary, int firstIndex, int secondIndex)
        {
            var temp = ary[firstIndex];
            ary[firstIndex] = ary[secondIndex];
            ary[secondIndex] = temp;
        }
    }
}