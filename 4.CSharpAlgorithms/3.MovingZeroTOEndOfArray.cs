using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    //Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    //For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].
    //Note:
    //You must do this in-place without making a copy of the array.
    //Minimize the total number of operations.
    //Source: https://leetcode.com/problems/move-zeroes/
    public static class MovingZeroTOEndOfArray
    {
        public static void Move(params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                    MoveZeroToEnd(x, i);
            }
        }
        private static void MoveZeroToEnd(int[] x, int index)
        {
            for (int i = index; i < x.Length - 1; i++)
            {
                int temp = x[i];
                x[i] = x[i + 1];
                x[i + 1] = temp;
            }
        }
        
    }
    class MovingZeroTOEndOfTheArrays { 
    public static void Main(string[] args)
    {
        MovingZeroTOEndOfArray.Move(1, 4, 5, 0, 5, 0);
    }
}
}

