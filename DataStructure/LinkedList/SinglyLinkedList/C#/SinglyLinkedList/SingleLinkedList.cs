using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    /// <summary>
    ///  SingleLinkedList class contains the the property Node head which --
    ///  is the start of the LinkedList. It also contains all the Methods -- 
    ///  to modify the List. 
    /// </summary>
    internal class SingleLinkedList
    {
        internal Node head;
        /// <summary>
        /// AddFirst Method is to add value from the beginning of the LinkedList
        /// </summary>
        /// <param name="linkedList"> the target LinkedList to be modified</param>
        /// <param name="new_date"> the new value which to added </param>
        internal void AddFirst(SingleLinkedList linkedList, int new_date)
        {
            // Create a new Node and sign the to value to new_node
            Node new_node = new Node(new_date);
            // Let the new_node next point to LinkedList head Node
            new_node.next = linkedList.head;
            // The LinkedList head now is the second Node in this List, 
            // then assign Linked List Node to new_data node,
            // now linkedList head Node is the new_node.
            linkedList.head = new_node;
        }
        /// <summary>
        /// AddEnd Method is to add value from the end of the LinkedList
        /// </summary>
        /// <param name="linkedList"> the target LinkedList to be modified</param>
        /// <param name="new_date"> the new value which to added </param>
        internal void AddEnd(SingleLinkedList linkedList, int new_data)
        {
            // Create a new Node and sign the to value to new_node
            Node new_node = new Node(new_data);
            // To check the list is exist
            if (linkedList.head == null)
            {
                // if the list is not exist, assign the new_node to this list head
                linkedList.head = new_node;
                return;
            }
            // If the list is exist, the method will call GetLastNode() method -- 
            // to find the last node in this list. 
            Node lastNode = GetLastNode(linkedList);
            // then point the lastNode next node to the new_node. 
            lastNode.next = new_node;
        }
        /// <summary>
        /// GetLastNode Method is to find the list last node 
        /// </summary>
        /// <param name="linkedList"> the target LinkedList to be modified</param>
        internal Node GetLastNode(SingleLinkedList linkedList)
        {
            // Create a temp Node point to the List head.
            Node temp = linkedList.head;
            // Iterate the List and find the last next node
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        /// <summary>
        /// InsertAfter Method is to add value from the specific Node.
        /// </summary>
        /// <param name="linkedList"> the target LinkedList to be modified</param>
        /// <param name="new_date"> the new value which to added </param>
        internal void InsertAfter(Node prev_node, int new_data)
        {
            // Check the Node has privous Node
            if (prev_node == null)
            {
                Console.WriteLine(" The previous node cannot be null");
                return;
            }
            //Create a new node and assign a value
            Node new_node = new Node(new_data);
            // Point new_node next Node to the previous node next 
            new_node.next = prev_node.next;
            // Point previous node next Node to the new_node
            prev_node.next = new_node;
        }
        /// <summary>
        /// DeleteNodeByKey Method is to delete the frist specific value in the list.
        /// </summary>
        /// <param name="linkedList"> the target LinkedList to be modified</param>
        /// <param name="key"> the value to delete </param>
        internal void DeleteNodeByKey(SingleLinkedList linkedList, int key)
        {
            // Create a temp Node and point to the list head 
            Node temp = linkedList.head;
            // Create a previous Node assign null 
            Node prev = null;
            // Check if the list is exist, and check if the head is the value to delete
            // then point head to the next value
            if (temp != null && temp.data == key)
            {
                linkedList.head = temp.next;
                return;
            }
            // Iterate the list, to find the key value.
            // if it find the key value, then assign the assign the key value's prev Node
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            // Break the prev node, and connect the list. 
            prev.next = temp.next;
        }
        //Add 6 to the head node
        //10  6  1  3  2  5  2  1     
        internal void DeleteAllNodeByKey(SingleLinkedList linkedList, int key)
        {
            Node temp = linkedList.head;
            Node prev = null;
            while (temp != null)
            {
                if (temp.data != key)
                {
                    prev = temp;
                }
                else
                {
                    if (prev != null)
                    {
                        prev.next = temp.next;
                    }
                    else
                    {
                        linkedList.head = temp.next;
                    }
                }
                temp = temp.next;
            }
        }
        /// <summary>
        /// Reverse Method is to turn over the value position in the list 
        /// </summary>
        /// <param name="linkedList"> the target LinkedList to be modified</param>
        /// //Add 6 to the head node
        //10  6  3  2  5  2   
        internal void Reverse(SingleLinkedList linkedList)
        {
            // Create a previous node 
            Node prev = null;
            // Create a current Node to point to list head 
            Node current = linkedList.head;
            // Create a temp Node which will contain current Node 
            Node temp = null;
            // Traverse the list 
            while (current != null)
            {
                // using temp node point to current next node 
                temp = current.next;
                // point current next node to prev which is null 
                current.next = prev;
                // set prev node to current node 
                prev = current;
                // set prev node to the next node that we want reverse
                current = temp;
            }
            // then set the last prev node point to head
            linkedList.head = prev;
        }
        // print the whole list
       public static void PrintList(SingleLinkedList linkedList)
        {
            Node currentNode = linkedList.head;
            
            if (linkedList.head == null)
            {
                Console.WriteLine("List is empty");
            }

            while (currentNode != null)
            {
                Console.Write(currentNode.data +  "  ");
                currentNode = currentNode.next;
               
            }

        }

    }
}
