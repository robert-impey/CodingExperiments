using System;
using System.Collections.Generic;
using System.Linq;

namespace Cache
{
    public class DictionaryLruCache : ILruCache
    {
        private readonly IDictionary<int, int> _values;
        private readonly IDictionary<int, int> _usages;

        private int _currentUsage;

        public DictionaryLruCache(int capacity)
        {
            Capacity = capacity;

            _values = new Dictionary<int, int>();
            _usages = new Dictionary<int, int>();

            _currentUsage = int.MinValue;
        }

        public int Capacity { get; }

        public int Get(int key)
        {
            if (!_values.ContainsKey(key))
            {
                return -1;
            }

            _usages[key] = _currentUsage;
            _currentUsage++;

            return _values[key];
        }

        public void Put(int key, int value)
        {
            // Possibly evict the least recently used
            if (!_values.ContainsKey(key) && _values.Count >= Capacity)
            {
                var minKey = _usages.Keys.First();
                var currentMin = _usages[minKey];

                foreach (var (usageKey, usageValue) in _usages)
                {
                    if (usageValue < currentMin)
                    {
                        minKey = usageKey;
                    }
                }

                _usages.Remove(minKey);
                _values.Remove(minKey);
            }

            _usages[key] = _currentUsage;
            _currentUsage++;

            _values[key] = value;
        }
    }
}