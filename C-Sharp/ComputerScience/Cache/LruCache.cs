using System;
using System.Collections.Generic;
using System.Linq;

namespace Cache
{
    public class LruCache : IIntCache
    {
        private readonly int _capacity;
        private readonly IDictionary<int, int> _values;
        private readonly IDictionary<int, int> _additions;
        private readonly IDictionary<int, int> _usages;

        private int _currentAddition;
        private int _currentUsage;
        
        public LruCache(int capacity)
        {
            _capacity = capacity;
            
            _values = new Dictionary<int, int>();
            _additions = new Dictionary<int, int>();
            _usages = new Dictionary<int, int>();

            _currentAddition = int.MinValue;
            _currentUsage = int.MinValue;
        }
        
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
            if (_values.Count >= _capacity)
            {
                if (_usages.Any())
                {
                    var currentMin = int.MaxValue;
                    int minKey = _usages.Keys.First();

                    foreach (var (usageKey, usageValue) in _usages)
                    {
                        if (usageValue <= currentMin)
                        {
                            minKey = usageKey;
                        }
                    }

                    _usages.Remove(minKey);
                    _additions.Remove(minKey);
                    _values.Remove(minKey);
                }
                else
                {
                    if (_additions.Any())
                    {
                        var currentMin = int.MaxValue;
                        int minKey = _additions.Keys.First();

                        foreach (var (additionKey, additionValue) in _additions)
                        {
                            if (additionValue <= currentMin)
                            {
                                minKey = additionKey;
                            }
                        }

                        _additions.Remove(minKey);
                        _values.Remove(minKey);
                    }
                    else
                    {
                        throw new Exception("No additions when over capacity!");
                    }
                }
            }

            _values[key] = value;

            _additions[key] = _currentAddition;
            _currentAddition++;
        }
    }
}