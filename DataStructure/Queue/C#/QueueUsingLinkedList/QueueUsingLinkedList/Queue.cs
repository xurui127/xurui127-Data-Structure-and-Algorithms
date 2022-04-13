using System;
using System.Collections.Generic;
using System.Text;

namespace QueueUsingLinkedList
{
   public class Queue
    {
        Node head;
        int index;

      public  bool IsEmpty()
        {
            if (index <1)
            {
                return true;
            }
            return false;
        }
       public Queue()
        {
            head = null;
            index = 0;
        }

        public void Enqueue(int _data)
        {
            Node new_Node = new Node(_data);
            new_Node.front = head;
            new_Node.rear = null;
            if(head != null)
            {
                head.rear = new_Node;
            }
            index++;
            head = new_Node;

        }

        public void Dequeue()
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                Node temp = head;
                Node prev = null;
                if (temp.front == null)
                {
                    head = null;
                    index--;
                    return;
                }
                while (temp.front != null)
                {
                    prev = temp;
                    temp = temp.front;
                }
                index--;
                prev.front = temp.front;
            }
        }
        public static void PrintQueue(Queue queue)
        {
            Node currentNode = queue.head;

            if (queue.head == null)
            {
                Console.WriteLine("Queue is empty");
            }

            while (currentNode != null)
            {
                Console.Write(currentNode.data + "  ");
                currentNode = currentNode.front;

            }
        }
    }
}
