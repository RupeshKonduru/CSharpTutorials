using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class BitCount
    {
        static void Main()
        {
            //SparseBitcount
            Console.WriteLine(SparseBitcount(0));
            Console.WriteLine(SparseBitcount(1));
            Console.WriteLine(SparseBitcount(int.MaxValue));
            Console.WriteLine(SparseBitcount(256));

            //IteratedBitCount
            Console.WriteLine(IteratedBitcount(0));
            Console.WriteLine(IteratedBitcount(1));
            Console.WriteLine(IteratedBitcount(int.MaxValue));
            Console.WriteLine(IteratedBitcount(256));
        }
        static int IteratedBitcount(int n)
        {
            int test = n;
            int count = 0;

            while (test != 0)
            {
                if ((test & 1) == 1)
                {
                    count++;
                }
                test >>= 1;
            }
            return count;
        }
        static int SparseBitcount(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }
    }
}
