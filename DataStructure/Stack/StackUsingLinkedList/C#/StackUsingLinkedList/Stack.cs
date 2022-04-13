using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingLinkedList
{
    class Stack
    {
        Node head;
        int index;
        public Stack()
        {
            head = null;
            index = 0;
        }

        public bool IsEmpty()
        {
            if (index < 1)
            {
                return true;
            }
            return false;
        }
        public Node GetTopNode()
        {
            Node top = head;
            while (top.next != null)
            {
                top = top.next;
            }
            return top;
        }
        public void Push(int _data)
        {
            Node newNode =new Node(_data);
            if (head == null)
            {
                head = newNode;
                index++;

            }
            else
            {
                Node top = GetTopNode();
                top.next = newNode;
                index++;
            }
               
          
           // Console.WriteLine("index: " + index + " value: "+ _data);
        }

        public void Pop()
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine(" \nStack Underflow");
                return;
            }
            else
            {
                Node temp = head;
                Node prev = null;
                if (temp.next == null)
                {
                    head = null;
                    index--;
                    return;
                }
                while (temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                    
                }
                index--;
                prev.next = temp.next;

            }
        }
        public void Peek()
        {
            Node temp = head;
            
            while (temp.next != null)
            {
                temp = temp.next;
            }
            Console.WriteLine("\nPeek Element : " + temp.data);
        }

        public static void PrintStack(Stack stack)
        {
            Node currentNode = stack.head;

            //if (stack.head == null)
            //{
            //    Console.WriteLine("List is empty");
            //}

            while (currentNode != null)
            {
                Console.Write(currentNode.data + "  ");
                currentNode = currentNode.next;

            }
        }
    }
}
