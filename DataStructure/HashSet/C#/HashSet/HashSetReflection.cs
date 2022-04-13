using System;
using System.Collections.Generic;
using System.Text;

namespace HashSet
{
    class HashSetReflection<Key,Value>
    {
        private LinkedList<Key,Value>[] hashTable;
        private int N; // hashTable size
        private int M; 


        public HashSetReflection(int M)
        {
            this.M = M;
            N = 0;
            hashTable = new LinkedList<Key,Value>[M];
            for (int i = 0; i < M; i++)
            {
                hashTable[i] = new LinkedList<Key,Value>();
            }
        }
        public HashSetReflection() : this(97) { }
        public int Count => N;
        public bool IsEmpty => N == 0;
        //private static int HashCode(string s)
        //{
        //    int hash = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        hash = 26 * hash + s[i];
        //    }
        //    return hash;
        //}
        private int Hash(Key key)
        {
            return key.GetHashCode() & 0x7fffffff % M;
        }

        public void Add(Key key,Value value)
        {
            LinkedList<Key,Value> list = hashTable[Hash(key)];
            if (list.Contains(key))
                list.Set(key, value);
            else
            {
                list.Add(key, value);
                N++;
            }

        }
        public void Remove(Key key)
        {
            LinkedList<Key,Value> list = hashTable[Hash(key)];
            if (list.Contains(key))
            {
                list.Remove(key);
                N--;
            }
        }
        public bool Contains(Key key)
        {
            LinkedList<Key,Value> list = hashTable[Hash(key)];
            return list.Contains(key);
        }
        public Value Get(Key key)
        {
            LinkedList<Key, Value> list = hashTable[Hash(key)];
            return list.Get(key);
        }
        public void Set(Key key, Value new_value)
        {
            LinkedList<Key, Value> list = hashTable[Hash(key)];
            list.Set(key, new_value);
        }
    }
}
