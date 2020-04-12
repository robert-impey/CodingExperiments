using System;
using System.Collections.Generic;

namespace Cache
{
    public class LruCache : IIntCache
    {
        private readonly int _capacity;
        private readonly IDictionary<int, int> _values;
        public LruCache(int capacity)
        {
            _capacity = capacity;
            _values = new Dictionary<int, int>();
        }
        
        public int Get(int key)
        {
            if (!_values.ContainsKey(key))
            {
                return -1;
            }

            return _values[key];
        }

        public void Put(int key, int value)
        {
            _values[key] = value;
        }
    }
}