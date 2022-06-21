using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class RightCircularROtationInArray
    {
        static void Main(string[] args)
        {
            int[] oneDimensionalArray = new int[6];
            Console.WriteLine("Enter the 1D Array Elements : ");
            for (int i = 0; i < oneDimensionalArray.Length; i++)
            {
                oneDimensionalArray[i] = int.Parse(Console.ReadLine());
            }

            int temp;
            for (int j = 0; j < oneDimensionalArray.Length - 1; j++)
            {
                temp = oneDimensionalArray[0];
                oneDimensionalArray[0] = oneDimensionalArray[j + 1];
                oneDimensionalArray[j + 1] = temp;
            }
            Console.WriteLine("Array Elements After Right Circular Rotation: ");
            foreach (int num in oneDimensionalArray)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
