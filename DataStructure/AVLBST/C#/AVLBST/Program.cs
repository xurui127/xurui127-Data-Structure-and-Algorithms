using System;

namespace AVLBST
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mSet = { 6,4,3,2,1,7,8 };
            AVLBST mAVLBST = new AVLBST(mSet);

            Console.WriteLine("======Pre Order=======");
            mAVLBST.PreOrder();
            Console.WriteLine("======In Order=======");
            mAVLBST.InOrder();
            Console.WriteLine("======Pos Order=======");
            mAVLBST.PosOrder();
        }
    }
}
