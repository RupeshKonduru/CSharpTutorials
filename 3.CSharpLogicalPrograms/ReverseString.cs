using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            char[] stringArray = originalString.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);

            Console.Write($"Reverse String is : {reverseString} ");

            //Method 2
            Console.Write("Enter a String : ");
            foreach (char c in originalString)
            {
                reverseString = c + reverseString;
            }
            Console.Write($"Reverse String is : {reverseString} ");

            //Method 3
            Console.Write("Enter a String : ");
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");

            Console.ReadLine();
        }
    }
}
