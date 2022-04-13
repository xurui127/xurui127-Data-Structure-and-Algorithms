using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubledLinkedList myList = new DoubledLinkedList();

            myList.AddEnd(myList, 1);
            myList.AddEnd(myList, 3);
            myList.AddEnd(myList, 4);
            myList.AddEnd(myList, 2);
            myList.AddEnd(myList, 7);
            myList.AddEnd(myList, 16);

            Console.WriteLine("---------Original List-------");
            DoubledLinkedList.PrintList(myList);
            
            
            Console.WriteLine("\n\n------ Test AddFirst Method ----------");
            Console.WriteLine("Add 10 to the first ");
            myList.AddFirst(myList, 10);
            DoubledLinkedList.PrintList(myList);

            Console.WriteLine("\n\n------ Test InserAfter Method ----------");
            Console.WriteLine("Add 6 to the head node ");
            myList.InsertAfter(myList.head, 6);
            DoubledLinkedList.PrintList(myList);

            Console.WriteLine("\n\n------ Test Delete Node By Key Method ----------");
            Console.WriteLine("delete first 1 in the linked list ");
            myList.DeleteNodeByKey(myList, 1);
            DoubledLinkedList.PrintList(myList);

            Console.WriteLine("\n\n------ Test Reverse Method ----------");
            myList.Reverse(myList);
            DoubledLinkedList.PrintList(myList);
        }
    }
}
