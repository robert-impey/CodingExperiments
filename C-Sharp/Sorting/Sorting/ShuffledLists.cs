namespace Sorting
{
    internal class ShuffledLists
    {
        private readonly int numberOfLists;
        private readonly int sizeOfLists;

        private readonly int[,] lists;

        internal ShuffledLists(int numberOfLists, int sizeOfLists, int[,] lists)
        {
            this.numberOfLists = numberOfLists;
            this.sizeOfLists = sizeOfLists;
            this.lists = lists;
        }

        internal int NumberOfLists
        {
            get { return this.numberOfLists; }
        }

        internal int SizeOfLists
        {
            get { return this.sizeOfLists; }
        }

        internal int[,] Lists
        {
            get { return lists; }
        }
    }
}