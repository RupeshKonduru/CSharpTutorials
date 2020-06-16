using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    /*
 * C# Program to Perform a Insertion Sort
 * ----------------------------------------
 * The Insertion sort algorithm views the data in two halves.
 The left half of sorted elements and the right half of elements to be sorted.
 In each iteration, one element from the right half is taken and added to the left half so that the left half is still sorted.
 Insertion sort is of order O(n2)
 Insertion sort takes an element from the list and places it in the correct location in the list.
 This process is repeated until there are no more unsorted items in the list.
 */
    using System;
    class Sorting_InsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 83, 12, 3, 34, 60 };
            int i;
            Console.WriteLine("The Array is :");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            insertsort(arr, 5);
            Console.WriteLine("The Sorted Array is :");
            for (i = 0; i < 5; i++)
                Console.WriteLine(arr[i]);
            Console.ReadLine();
        }
        static void insertsort(int[] data, int n)
        {
            int i, j;
            for (i = 1; i < n; i++)
            {
                int item = data[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
        }
    }
}
