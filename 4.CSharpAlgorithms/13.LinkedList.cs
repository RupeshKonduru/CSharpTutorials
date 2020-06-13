using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class singleLinkedlist
    {
        private int data;
        private singleLinkedlist next;
        public singleLinkedlist()
        {
            data = 0;
            next = null;
        }
        public singleLinkedlist(int value)
        {
            data = value;
            next = null;
        }
        public singleLinkedlist InsertNext(int value)
        {

            singleLinkedlist node = new singleLinkedlist(value);
            if (this.next == null)
            {
                node.next = null;
                this.next = node;
            }
            else
            {
                singleLinkedlist temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }
        public int DeleteNext()
        {
            if (next == null)
                return 0;
            singleLinkedlist node = this.next;
            this.next = this.next.next;
            node = null;
            return 1;
        }
        public void Traverse(singleLinkedlist node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("Traversing Singly Linked List :");
            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }
    class LinkedList
    {
        static void Main(string[] args)
        {
            singleLinkedlist node1 = new singleLinkedlist(100);
            singleLinkedlist node2 = node1.InsertNext(200);
            singleLinkedlist node3 = node2.InsertNext(300);
            singleLinkedlist node4 = node3.InsertNext(400);
            singleLinkedlist node5 = node4.InsertNext(500);
            node1.Traverse(null);
            Console.WriteLine("Deleting from Linked List...");
            node3.DeleteNext();
            node2.Traverse(null);
            System.Console.ReadLine();
        }
    }
}
