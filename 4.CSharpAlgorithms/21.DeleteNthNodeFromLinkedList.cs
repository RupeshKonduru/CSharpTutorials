//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpAlgorithms
//{
//    class DeleteNthNodeFromLinkedList
//    {
//        //Deletes nth item from head (Ex. passing a 1 deletes the head node)
//        public void Delete(int x)
//        {
//            if ((x > Count) || (x < 1))
//                throw new Exception("Out of range");

//            if (x == 1)
//            {
//                head = head.Next;
//                return;
//            }
//            Node lag = head;
//            Node lead = head.Next;
//            //lag Node will point at the node before the Node we want to delete, lead is set to the node
//            //set to be deleted
//            for (int i = 2; i < x; i++)
//            {
//                lag = lag.Next;
//                lead = lead.Next;
//            }
//            //Skip the node to be deleted
//            lag.Next = lead.Next;
//        }
//    }
//}
