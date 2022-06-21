using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class PossibleSubString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();

            Console.WriteLine("All substrings for given string are : ");

            for (int i = 0; i < inputString.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);
                for (int j = i; j < inputString.Length; ++j)
                {
                    subString.Append(inputString[j]);
                    Console.Write(subString + " ");
                }
            }

            //Method 2
            int len = inputString.Length;
            Console.WriteLine("All substrings for given string are : ");

            //This loop maintains the starting character  
            for (int i = 0; i < len; i++)
            {
                //This loop adds the next character every iteration for the substring and then print
                for (int j = 0; j < len - i; j++)
                {
                    Console.Write(inputString.Substring(i, j + 1) + " ");
                }
            }

            //Method 3
            int temp = 0;
            //Total possible substrings for string of size n is n*(n+1)/2  
            String[] SubstringArray = new String[len * (len + 1) / 2];

            //This loop maintains the starting character  
            for (int i = 0; i < len; i++)
            {
                //This loop adds the next character every iteration for the substring 
                //and then store into the array
                for (int j = 0; j < len - i; j++)
                {
                    SubstringArray[temp] = inputString.Substring(i, j + 1);
                    temp++;
                }
            }
            //Get the distinct array  
            SubstringArray = SubstringArray.Distinct().ToArray();
            //Print the array  
            Console.WriteLine("All Unique substrings for given string are : ");
            for (int i = 0; i < SubstringArray.Length; i++)
            {
                Console.Write(SubstringArray[i] + " ");
            }

            //Method 4
            var Substrings =
                from i in Enumerable.Range(0, inputString.Length)
                from j in Enumerable.Range(0, inputString.Length - i + 1)
                where j >= 1
                select inputString.Substring(i, j);
            //Print the array 
            Console.WriteLine();
            Console.WriteLine("All substrings for given string are : ");
            foreach (string substring in Substrings)
            {
                Console.Write(substring + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All Unique substrings for given string are : ");
            foreach (string substring in Substrings.Distinct())
            {
                Console.Write(substring + " ");
            }
            Console.ReadKey();
        }
    }
}
