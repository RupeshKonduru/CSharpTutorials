using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class ArrayDuplication
    {
        //Given an array of integers, find if the array contains any duplicates.
        //Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
        public static bool ContainsDuplicates(params int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (int i in x)
            {
                if (d.ContainsKey(i))
                    return true;
                else
                    d.Add(i, 1);
            }
            return false;
        }

        
    }
    class ArrayDuplications
    {
        public static void Main(string[] args)
        {
            ArrayDuplication.ContainsDuplicates(1, 2, 3, 4, 5, 5, 5, 6, 6);
        }

    }


}
