using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
        public static class TwoInterSumToGIvenInteger
        {
            //Brute force solution, O(n^2) time complexity
            public static bool TwoIntegersSumToTarget(int[] arr, int target)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (i != k)
                        {
                            int sum = arr[i] + arr[k];
                            if (sum == target)
                                return true;
                        }
                    }
                }
                return false;
            }
        
    }
    class TwoIntegersSumToGivenTargets
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 4;
            arr[2] = 6;
            arr[3] = 3;
            TwoInterSumToGIvenInteger.TwoIntegersSumToTarget(arr, 4);
        }
    }
        
}
