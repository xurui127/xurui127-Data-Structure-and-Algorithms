using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingLinkedList
{
    public class Node
    {
        public Node next;
        public int data;
        public Node(int _data)
        {
            data = _data;
            next = null;
       
        }
    }
}
