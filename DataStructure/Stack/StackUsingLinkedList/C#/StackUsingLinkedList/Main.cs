using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingLinkedList
{
    class Progame
    {
        static void Main(string[] args)
        {

            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            Console.WriteLine(" ------ Original Stack ----------");
            Stack.PrintStack(myStack);

            Console.WriteLine("\n\n ------ Pop Stack ----------");
            myStack.Pop();
            //myStack.Pop();
            //myStack.Pop();
            //myStack.Pop();
            //myStack.Pop();
            Stack.PrintStack(myStack);


            Console.WriteLine("\n\n ------ Peek Element ----------");
            myStack.Peek();
        

 
  
            
        }
    }
}
