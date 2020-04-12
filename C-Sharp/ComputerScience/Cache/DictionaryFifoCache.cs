namespace Cache
{
    public class DictionaryFifoCache : IFifoCache
    {
        public DictionaryFifoCache(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; }

        public int Get(int key)
        {
            throw new System.NotImplementedException();
        }

        public void Put(int key, int value)
        {
            throw new System.NotImplementedException();
        }
    }
}