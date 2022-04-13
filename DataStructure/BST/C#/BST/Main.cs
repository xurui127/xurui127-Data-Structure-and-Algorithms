using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 4, 2, 1, 3, 6, 7 };
            BST myBST = new BST(test);
            myBST.InOrder();
            myBST.Remove(4);
            myBST.PreOder();
            myBST.PreOder();
            myBST.PosOder();
            myBST.BreadthFirst();

            //============= Test 2 ==========
            //int[] test2 = {6, 4, 3, 2, 7, 1 };
            //BST myBST2 = new BST(test2);
            //myBST2.PreOder();
            // myBST2.InOrder();
        }

    }
}
