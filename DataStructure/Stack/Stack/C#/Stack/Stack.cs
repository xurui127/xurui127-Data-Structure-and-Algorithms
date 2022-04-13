using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
   public class Stack
    {
     
        int top = 0;
        Node head;
       // Node tail;

        public bool IsEmpty()
        {
            if(top > 1)
            {
                return true;
            }
            return false;
        }

        public int Size()
        {
            
            Node temp = head;
            int size = 0;
            while (temp.next != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
        public Node GetLastNode()
        {
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
               
               
            }
            return temp;
        }
        public void Push(int data)
        {
            Node new_Node = new Node(data);
            if (head == null)
            {
                head = new_Node;
                top++;
           
                return;
            }
            top++;
            Console.WriteLine("Top:  " + top + " ");
            Node lastNode = GetLastNode();
            lastNode.next = new_Node;
        }
        public void Pop()
        {
            Node prev = null;
            Node temp = head; 
            if (IsEmpty() == false)
            {
                Console.WriteLine("Stack is underflow");
            }
            else
            {
                top--;
                // head = head.next;
                while (temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                    
                 
                }
                //Node lastNode = GetLastNode();
                //lastNode = null;
                Console.WriteLine("\nTop:  " + top + " ");
                prev.next = null;
               ;
            }
        }

        public static void PrintStack(Stack S)
        {
            Node currentNode = S.head;

            if (S.head == null)
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
