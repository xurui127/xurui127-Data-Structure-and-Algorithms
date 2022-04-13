using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class LinkedList<T>
    {
        #region // Node Class
        private class Node
        {
            public T data;
            public Node next;

            public Node(T _data)
            {
                data = _data;
                next = null;
            }
            public Node(T _data, Node _next)
            {
                data = _data;
                next = _next;
            }
            public override string ToString()
            {
                return data.ToString();
            }
        }
        #endregion
        #region // LinkedList Class
        private Node head;

        private int index; // how many data this Linked List saved

        public LinkedList()
        {
            head = null;
            index = 0;
        }

        public int Count => index;
        public bool IsEmpty => index == 0;

        public void Add(int _index, T _data)
        {
            if (index < 0 || _index > index)
            {
                throw new AggregateException(" Can not Add");
            }
            if (index == 0)
            {
                //Node new_Node = new Node(_data);
                //new_Node.next = head;
                //head = new_Node;
                head = new Node(_data, head);
            }
            else
            {
                Node prev = head;
                for (int i = 0; i < index - 1; i++)
                    prev = prev.next;

                //Node new_node = new Node(_data);
                //new_node.next = prev.next;
                //prev.next = new_node;
                prev.next = new Node(_data, prev.next);
            }
            index++;
        }

        public void AddFirst(T _data)
        {
            Add(0, _data);
        }
        public void AddLast(T _data)
        {
            Add(index, _data);
        }

        private T GetElement(int _index)
        {
            if (index < 0 || _index > index)
            {
                throw new AggregateException(" Can not Add");
            }

            Node cur_Node = head;
            for (int i = 0; i < _index; i++)
            {
                cur_Node = cur_Node.next;
            }

            return cur_Node.data;
        }


        public T GetFirst()
        {
            return GetElement(0);
        }

        public T GetLast()
        {
            return GetElement(index - 1);
        }

        public void SetElement(int _index, T new_data)
        {
            if (index < 0 || _index > index)
            {
                throw new AggregateException(" Can not Add");
            }
            Node cur_Node = head;
            for (int i = 0; i < _index; i++)
            {
                cur_Node = cur_Node.next;
            }
            cur_Node.data = new_data;


        }

        public T RemoveAt(int _index)
        {
            if (index < 0 || _index > index)
            {
                throw new AggregateException(" Can not Add");
            }
            if (index == 0)
            {
                Node delNode = head;
                head = head.next;
                index--;
                return delNode.data;
            }
            else
            {
                Node prev = head;
                for (int i = 0; i < _index - 1; i++)
                    prev = prev.next;
                Node delNode = prev.next;
                prev.next = delNode.next;
                index--;
                return delNode.data;
            }

        }
        public T RemoveFirst()
        {
            return RemoveAt(0);
        }
        public T RemoveLast()
        {
            return RemoveAt(index - 1);
        }

        public void Remove(T _data)
        {
            if (head == null)
            {
                return;
            }
            if (head.Equals(_data))
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
                    if (cur.data.Equals(_data))
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
        public bool Contains(T _data)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.data.Equals(_data))
                    return true;
                cur = cur.next;

            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur + "->");
                cur = cur.next;
            }
            res.Append("Null");
            return res.ToString();
        }

    }
    #endregion
}
