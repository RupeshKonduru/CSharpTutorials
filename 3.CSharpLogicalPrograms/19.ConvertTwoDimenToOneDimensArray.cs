using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class ConvertTwoDimenToOneDimensArray
    {
        static void Main(string[] args)
        {
            //Creating a 2d Array with 2 rows and three columns
            int[,] int2DArray = new int[2, 3];
            Console.Write("Enter 2D Array Elements : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int2DArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int index = 0;
            //Getting the no of rows of 2d array 
            int NoOfRows = int2DArray.GetLength(0);
            //Getting the no of columns of the 2d array
            int NoOfColumns = int2DArray.GetLength(1);
            //Creating 1d Array by multiplying NoOfRows and NoOfColumns
            int[] OneDimensionalArray = new int[NoOfRows * NoOfColumns];

            //Assigning the elements to 1d Array from 2d array
            for (int y = 0; y < NoOfColumns; y++)
            {
                for (int x = 0; x < NoOfRows; x++)
                {
                    OneDimensionalArray[index] = int2DArray[x, y];
                    index++;
                }
            }
            //Printing the 1d array elements
            Console.WriteLine("1D Array Elements : ");
            foreach (int item in OneDimensionalArray)
            {
                Console.Write(item + " ");
            }

            //Method 2
            //Assigning the elements to 1d Array from 2d array
            for (int y = 0; y < NoOfRows; y++)
            {
                for (int x = 0; x < NoOfColumns; x++)
                {
                    OneDimensionalArray[index] = int2DArray[y, x];
                    index++;
                }
            }
            //Printing the 1d array elements
            Console.WriteLine("1D Array Elements : ");
            foreach (int item in OneDimensionalArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
