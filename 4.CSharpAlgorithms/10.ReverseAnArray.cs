using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class ReverseAnArray
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            Array.Reverse(array);
            Console.WriteLine("Reversed Array : ");
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
