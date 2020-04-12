using System;

namespace Cache
{
    public class LruCache : IIntCache
    {
        private readonly int _capacity;

        public LruCache(int capacity)
        {
            _capacity = capacity;
        }
        
        public int Get(int key)
        {
            throw new NotImplementedException();
        }

        public void Put(int key, int value)
        {
            throw new NotImplementedException();
        }
    }
}