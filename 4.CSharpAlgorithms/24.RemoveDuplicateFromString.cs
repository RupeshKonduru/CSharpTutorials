using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class RemoveDuplicateFromString
    {
        static void Main()
        {
            string value1 = RemoveDuplicateChars("Csharpstar");
            string value2 = RemoveDuplicateChars("Google");
            string value3 = RemoveDuplicateChars("Yahoo");
            string value4 = RemoveDuplicateChars("CNN");
            string value5 = RemoveDuplicateChars("Line1\nLine2\nLine3");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);
        }

        static string RemoveDuplicateChars(string key)
        {
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (table.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }
            return result;
        }
    }
}
