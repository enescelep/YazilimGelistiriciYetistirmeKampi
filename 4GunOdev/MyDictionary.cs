using System;
using System.Collections.Generic;
using System.Text;

namespace _4GunOdev
{
    class MyDictionary<K, V>
    {
        private List<K> _keys;
        private List<V> _values;

        public MyDictionary()
        {
            _keys = new List<K>();
            _values = new List<V>();
        }
        public void Add(K key, V value)
        {
            _keys.Add(key);
            _values.Add(value);
        }
        public int Length
        {
            get { return _keys.Count; }
        }
        public V GetValue(K key)
        {
            int index = _keys.IndexOf(key);
            V value = _values[index];
            return value;
        }
        public K GetKey(V value)
        {
            int index = _values.IndexOf(value);
            K key = _keys[index];
            return key;
        }
    }
}
