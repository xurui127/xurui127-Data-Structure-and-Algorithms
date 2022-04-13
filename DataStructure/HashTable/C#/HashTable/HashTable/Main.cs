using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                linkedList.AddFirst(i);
                Console.WriteLine(linkedList);
            }

            linkedList.AddLast(7);
            Console.WriteLine(linkedList);

            linkedList.SetElement(2, 44);
            Console.WriteLine(linkedList); //0->1->44->3->4->7->Null

            linkedList.RemoveAt(2);
            Console.WriteLine(linkedList); //0->1->3->4->7->Null

            linkedList.RemoveFirst();
            Console.WriteLine(linkedList); //0->3->4->7->Null

            linkedList.RemoveLast();
            Console.WriteLine(linkedList); //0->3->4->Null


        }
    }
}
