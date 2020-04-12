using System.Collections.Generic;
using System.Linq;

namespace Cache
{
    public class DictionaryFifoCache : IFifoCache
    {
        private readonly IDictionary<int, int> _dictionary;
        private readonly IDictionary<int, int> _additions;

        private int _currentAddition;
        
        public DictionaryFifoCache(int capacity)
        {
            Capacity = capacity;
            
            _dictionary = new Dictionary<int, int>();
            _additions = new Dictionary<int, int>();

            _currentAddition = int.MinValue;
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
            if (_dictionary.Count() >= Capacity)
            {
                var minKey = _additions.Keys.First();
                var minAddition = _additions[minKey];

                foreach (var (additionKey, additionValue) in _additions)
                {
                    if (additionValue <= minAddition)
                    {
                        minKey = additionKey;
                    }
                }

                _additions.Remove(minKey);
                _dictionary.Remove(minKey);
            }

            _additions[key] = _currentAddition;
            _currentAddition++;
            
            _dictionary[key] = value;
        }
    }
}