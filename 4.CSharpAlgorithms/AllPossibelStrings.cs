using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class AllPossibelStrings
    {
        static void Main()
        {
            string value = "rstuvwxyz";
            // Avoid full length.
            for (int length = 1; length < value.Length; length++)
            {
                // End index is tricky.
                for (int start = 0; start <= value.Length - length; start++)
                {
                    string substring = value.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }   
    }
}
