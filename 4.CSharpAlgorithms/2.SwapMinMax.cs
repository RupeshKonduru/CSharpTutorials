using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CSharpAlgorithms
{
    class SwapMinMax
    {
        //Write a method to swap the min and max element in an integer array
        //Source: Cracking Coding Interview p. 58
        public static class MinMaxArraySwap
        {
            public static void MinMaxSwap(int[] input)
            {
                if (input.Length == 0)
                    return;

                int maxPos = 0;
                int minPos = 0;
                int valMax = 0;
                int valMin = 0;

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[maxPos] < input[i])
                        maxPos = i;
                    if (input[minPos] > input[i])
                        minPos = i;
                }
                valMax = input[maxPos];
                valMin = input[minPos];
                input[maxPos] = valMin;
                input[minPos] = valMax;
            }

            //Cleaner implementation
            public static void MinMaxSwap2(int[] x)
            {
                int min = 0;
                int max = 0;

                for (int i = 1; i < x.Length; i++)
                {
                    if (x[min] > x[i])
                        min = i;
                    if (x[max] < x[i])
                        max = i;
                }
                int temp = x[min];
                x[min] = x[max];
                x[max] = temp;
            }
        }
    }
}
