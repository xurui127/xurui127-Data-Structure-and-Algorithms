using System;
using System.Collections.Generic;
using System.Text;

namespace HashSet
{
   internal class Dictionary<Key,Value>
    {
        internal LinkedList<Key, Value> list;
        internal Dictionary()
        {
            list = new LinkedList<Key, Value>();
        }
        internal int Count => list.Count;
        internal bool IsEmpty => list.IsEmpty;

        internal void Add(Key _key,Value _value)
        {
            list.Add(_key, _value);
        }
        internal bool ContainsKey(Key _key)
        {
            return list.Contains(_key);
        }
        internal Value Get(Key _key)
        {
            return list.Get(_key);

        }
        internal void Remove(Key _key)
        {
            list.Remove(_key);
        }
        internal void Set(Key _key, Value _value)
        {
            list.Set(_key, _value);
        }
    }
}
