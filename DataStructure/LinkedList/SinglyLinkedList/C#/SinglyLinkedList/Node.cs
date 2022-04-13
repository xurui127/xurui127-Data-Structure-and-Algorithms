using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    /// <summary>
    /// Node class contains the data and the link(next).
    ///  the Node next can point to the " next " value that we want save to the list. 
    /// </summary>
   internal class Node
    {
        
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
