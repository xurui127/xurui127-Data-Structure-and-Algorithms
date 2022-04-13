using System;
using System.Collections.Generic;
using System.Text;

namespace QueueUsingLinkedList
{
  public class Node
    {
        public Node front;
        public Node rear;
        public int data;
       public Node(int _data)
        {
            front = null;
            rear = null;
            data = _data;
        }

    }
}
