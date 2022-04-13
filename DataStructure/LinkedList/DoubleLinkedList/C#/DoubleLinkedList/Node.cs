using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
   internal class Node
    {
        public int data;
        public Node prev;
        public Node next;
        public Node(int _data)
        {
            data = _data;
            prev = null;
            next = null;
        }
    }
}
