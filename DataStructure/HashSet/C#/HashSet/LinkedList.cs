using System;
using System.Collections.Generic;
using System.Text;

namespace HashSet
{
    class LinkedList<Key, Value>
    {
        class Node
        {
            public Key key;
            public Value value;
            public Node next;

            public Node(Key key, Value value,Node next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }

            public override string ToString()
            {
                return key.ToString() + " : " + value.ToString();
            }
        }

        private Node head;
        private int index;

        public LinkedList()
        {
            head = null;
            index = 0;
        }
        public int Count => index;
        public bool IsEmpty => index == 0;

        private Node GetNode(Key key)
        {
            Node cur = head;
            while(cur != null)
            {
                if (cur.key.Equals(key))
                {
                    return cur;
                }
                cur = cur.next;
            }
            return null;
        }
        public void Add(Key _key, Value _value)
        {
            Node node = GetNode(_key);
            if (node == null)
            {
                head = new Node(_key, _value,head);
            }
            else
            {
                node.value = _value;
            }
        }
        public bool Contains(Key _key)
        {
            return GetNode(_key) != null;
        }

        public Value Get(Key _key)
        {
            Node node = GetNode(_key);
            if (node == null)
            {
                throw new ArgumentException("Key " + _key + "is not exist ");

            }
            else
            {
                return node.value;
            }
        }
        public void Set(Key _key,Value new_Value)
        {
            Node node = GetNode(_key);
            if (node == null)
            {
                throw new ArgumentException("Key " + _key + "is not exist ");
            }
            else
            {
                node.value = new_Value;
            }
        }
        public void Remove(Key _key)
        {
            if (head == null)
            {
                return;
            }
            if (head.Equals(_key))
            {
                head = head.next;
                index--;
            }
            else
            {
                Node cur = head;
                Node prev = null;
                while (cur != null)
                {
                    if (cur.key.Equals(_key))
                    {
                        break;
                    }
                    prev = cur;
                    cur = cur.next;
                }
                if (cur != null)
                {
                    prev.next = prev.next.next;
                    index--;
                }
            }
        }
    }
}
