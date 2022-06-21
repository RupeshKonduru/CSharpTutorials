using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class RemoveDuplicateCharacterFromString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }
            }
            Console.WriteLine(resultString);

            //Method 2
            var unique = new HashSet<char>(inputString);
            foreach (char c in unique)
            {
                resultString += c;
            }
            Console.WriteLine("After Removing Duplicates : " + resultString);

            //Method 3 
            var uniqueCharArray = inputString.ToCharArray().Distinct().ToArray();
            var resultStrings = new string(uniqueCharArray);
            Console.WriteLine("After Removing Duplicates : " + resultStrings);

            Console.ReadKey();
        }
    }
}
