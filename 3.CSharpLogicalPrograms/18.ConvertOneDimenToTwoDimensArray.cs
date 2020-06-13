using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class ConvertOneDimenToTwoDimensArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Rows : ");
            int Rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the Number of Columns : ");
            int Columns = int.Parse(Console.ReadLine());
            //Creating a 1d Array 
            Console.WriteLine("Enter the 1D Array Elements : ");
            int[] oneDimensionalArray = new int[Rows * Columns];
            for (int i = 0; i < oneDimensionalArray.Length; i++)
            {
                oneDimensionalArray[i] = int.Parse(Console.ReadLine());
            }

            //Creating 2d Array
            int index = 0;
            int[,] twoDimensionalArray = new int[Rows, Columns];

            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    twoDimensionalArray[x, y] = oneDimensionalArray[index];
                    index++;
                }
            }
            //Printing the 2D array elements
            Console.WriteLine("2D Array Elements : ");
            foreach (int item in twoDimensionalArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
