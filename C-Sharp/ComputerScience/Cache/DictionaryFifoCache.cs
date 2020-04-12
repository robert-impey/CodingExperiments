using System.Collections.Generic;

namespace Cache
{
    public class DictionaryFifoCache : IFifoCache
    {
        private readonly IDictionary<int, int> _dictionary;
        
        public DictionaryFifoCache(int capacity)
        {
            Capacity = capacity;
            
            _dictionary = new Dictionary<int, int>();
        }

        public int Capacity { get; }

        public int Get(int key)
        {
            if (!_dictionary.ContainsKey(key))
            {
                return -1;
            }

            return _dictionary[key];
        }

        public void Put(int key, int value)
        {
            _dictionary[key] = value;
        }
    }
}