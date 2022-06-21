using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class ReverseEachWordInSentence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            StringBuilder reverseWordString = new StringBuilder();
            List<char> charlist = new List<char>();
            for (int i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == ' ' || i == originalString.Length - 1)
                {
                    if (i == originalString.Length - 1)
                        charlist.Add(originalString[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        reverseWordString.Append(charlist[j]);
                    reverseWordString.Append(' ');
                    charlist = new List<char>();
                }
                else
                {
                    charlist.Add(originalString[i]);
                }
            }
            Console.WriteLine($"Reverse Word String : {reverseWordString.ToString()}");

            //Method 2
            Stack<char> charStack = new Stack<char>();
            // Traverse the given string and push all characters
            // to stack until we see a space.  
            for (int i = 0; i < originalString.Length; ++i)
            {
                if (originalString[i] != ' ')
                {
                    charStack.Push(originalString[i]);
                }
                // When seeing a space, then print contents of the stack.  
                else
                {
                    while (charStack.Count > 0)
                    {
                        Console.Write(charStack.Pop());
                    }
                    Console.Write(" ");
                }
            }
            // Since there may not be space after last word.  
            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }

            //Method 3
            string reverseWordStrings = string.Join(" ", originalString
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine($"Reverse Word String : {reverseWordStrings}");

            Console.ReadKey();
        }
    }
}
