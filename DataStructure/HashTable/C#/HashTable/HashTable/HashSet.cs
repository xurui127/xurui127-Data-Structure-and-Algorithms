using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class HashSet<Key>
    {
        private HashTable<Key> hashSet;
        private int elementIndex;
        private int listIndex;

        public HashSet()
        {
            hashSet = new HashTable<Key>();
        }
        public HashSet(int _listIndex)
        {
            hashSet = new HashTable<Key>(_listIndex);
        }
        public int Count => hashSet.Count;
        public bool IsEmpty => hashSet.IsEmpty;

    

        public void Add(Key key)
        {
            hashSet.Add(key);
        }
        public void Remove(Key key)
        {
            hashSet.Remove(key);
        }
        public bool Contains(Key key)
        {
           return hashSet.Contains(key);
        }
    }
}

