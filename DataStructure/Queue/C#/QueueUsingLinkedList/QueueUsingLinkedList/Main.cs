using System;
using System.Collections.Generic;
using System.Text;

namespace QueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue myQueue = new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            Console.WriteLine(" ------ Original Stack ----------");
            Queue.PrintQueue(myQueue);

            Console.WriteLine("\n\n ------ Dequeue  ----------");
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();

            Console.WriteLine("\n\n ------ Enqueue number 8  ----------");
            myQueue.Enqueue(8);

            Queue.PrintQueue(myQueue);




        }
    }
}
