using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
   internal class DoubledLinkedList
    {
        public Node head;

        internal void AddFirst(DoubledLinkedList doubledLinkedList, int data)
        {
            Node new_node = new Node(data);
            new_node.next = doubledLinkedList.head;
            new_node.prev = null;
            if (doubledLinkedList.head != null)
            {
                doubledLinkedList.head.prev = new_node;
            }
            doubledLinkedList.head = new_node;
        }
        internal void AddEnd(DoubledLinkedList doubledLinkedList, int data)
        {
            Node new_node = new Node(data);
            if (doubledLinkedList.head ==null)
            {
                new_node.prev = null;
                doubledLinkedList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(doubledLinkedList);
            lastNode.next = new_node;
            new_node.prev = lastNode;
        }

        internal Node GetLastNode(DoubledLinkedList doubledLinkedList)
        {
            Node temp = doubledLinkedList.head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        internal void InsertAfter(Node prev_node, int data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The List can not be null");
                return;
            }
            Node new_node = new Node(data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
            new_node.prev = prev_node;
            if (new_node.next != null)
            {
                new_node.next.prev = new_node;
            }
        }
        internal void DeleteNodeByKey(DoubledLinkedList doubledLinkedList, int key)
        {
            Node temp = doubledLinkedList.head;
            if (temp != null&&temp.data ==key)
            {
                doubledLinkedList.head = temp.next;
                doubledLinkedList.head.prev = null;
            }
            while(temp!= null && temp.data != key)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next!= null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev!=null)
            {
                temp.prev.next = temp.next;
            }
        }
        internal void Reverse(DoubledLinkedList doubledLinkedList)
        {
            Node temp = null;
            Node current = doubledLinkedList.head;
            while (current != null)
            {
                temp = current.prev;
                current.prev = current.next;
                current.next = temp;
                current = current.prev;
            }
            if (temp != null)
            {
                doubledLinkedList.head = temp.prev;
            }
        }
        public static void PrintList(DoubledLinkedList linkedList)
        {
            Node currentNode = linkedList.head;

            if (linkedList.head == null)
            {
                Console.WriteLine("List is empty");
            }

            while (currentNode != null)
            {
                Console.Write(currentNode.data + "  ");
                currentNode = currentNode.next;

            }

        }
    }
}
