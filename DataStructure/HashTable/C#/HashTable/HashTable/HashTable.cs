using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class HashTable<Key>
    {
        private LinkedList<Key>[] hashTable;
        private int elementIndex;
        private int listIndex;

        public HashTable(int _index)
        {
            elementIndex = _index;
            listIndex = 0;
            hashTable = new LinkedList<Key>[_index];
            for (int i = 0; i < _index; i++)
            {
                hashTable[i] = new LinkedList<Key>();
            }

        }
        public HashTable() : this(97) { }
        public int Count => elementIndex;
        public bool IsEmpty => elementIndex == 0;

        private int Hash(Key key)
        {
            return (key.GetHashCode() & 0x7fffffff % listIndex);
        }

        public void Add(Key key)
        {
            LinkedList<Key> list = hashTable[Hash(key)];
            if (list.Contains(key)) return;
            else
            {
                list.AddFirst(key);
                elementIndex++;
            }
        }
        public void Remove(Key key)
        {
            LinkedList<Key> list = hashTable[Hash(key)];
            if (list.Contains(key))
            {
                list.Remove(key);
                elementIndex--;
            }
        }
        public bool Contains(Key key)
        {
            LinkedList<Key> list = hashTable[Hash(key)];
            return list.Contains(key);
        }
    }
}

