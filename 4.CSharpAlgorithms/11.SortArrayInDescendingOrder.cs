using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    //Write a method to sort the elements of an array in descending order
    public static class SortArrayInDescendingOrder
    {
        public static void Sort(int[] x)
        {
            Array.Sort(x);
            Array.Reverse(x);
        }
    }
    //Find other process without using keywords
    class SortArrayInDescending
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 4;
            arr[2] = 6;
            arr[3] = 3;
            SortArrayInDescendingOrder.Sort(arr);
        }
    }
}
