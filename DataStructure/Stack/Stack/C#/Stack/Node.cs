using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
   public class Node
    {
       public int data;
       public Node next;
       public Node(int _data)
        {
            data = _data;
            next = null;
        }
    }
}
