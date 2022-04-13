using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList myList = new SingleLinkedList();

            myList.AddEnd(myList, 1);
            myList.AddEnd(myList,3);
            myList.AddEnd(myList, 2);
            myList.AddEnd(myList, 5);
            myList.AddEnd(myList, 2);
            myList.AddEnd(myList, 1);

            Console.WriteLine(" ------ Original List ----------");
            SingleLinkedList.PrintList(myList);
            Console.WriteLine("\n\n------ Test AddFirst Method ----------");
            Console.WriteLine("Add 10 to the first ");
            myList.AddFirst(myList,10);
            SingleLinkedList.PrintList(myList);

            Console.WriteLine("\n\n------ Test InserAfter Method ----------");
            Console.WriteLine("Add 6 to the head node ");
            myList.InsertAfter(myList.head, 6);
            SingleLinkedList.PrintList(myList);

            //Console.WriteLine("\n\n------ Test Delete Node By Key Method ----------");
            //Console.WriteLine("delete first 1 in the linked list ");
            //myList.DeleteNodeByKey(myList, 1);
            //SingleLinkedList.PrintList(myList);  
            
            Console.WriteLine("\n\n------ Test Delete All Node By Key Method ----------");
            Console.WriteLine("delete first 1 in the linked list ");
            myList.DeleteAllNodeByKey(myList, 1);
            SingleLinkedList.PrintList(myList);

            Console.WriteLine("\n\n------ Test Reverse Method ----------");
            myList.Reverse(myList);
            SingleLinkedList.PrintList(myList);
            
        }
    }
}