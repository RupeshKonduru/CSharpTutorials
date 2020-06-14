using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class PreComputedBitCount
    {
        static void Main()
        {
            //
            // Initialize the lookup table.
            //
            InitializeBitcounts();
            //
            // Get the bitcounts for these values by lookups.
            //
            Console.WriteLine(PrecomputedBitcount(0));
            Console.WriteLine(PrecomputedBitcount(1));
            Console.WriteLine(PrecomputedBitcount(int.MaxValue));
            Console.WriteLine(PrecomputedBitcount(256));
        }

        static int[] _bitcounts; // Lookup table

        static void InitializeBitcounts()
        {
            _bitcounts = new int[65536];
            int position1 = -1;
            int position2 = -1;
            //
            // Loop through all the elements and assign them.
            //
            for (int i = 1; i < 65536; i++, position1++)
            {
                //
                // Adjust the positions we read from.
                //
                if (position1 == position2)
                {
                    position1 = 0;
                    position2 = i;
                }
                _bitcounts[i] = _bitcounts[position1] + 1;
            }
        }

        static int PrecomputedBitcount(int value)
        {
            //
            // Count bits in each half of the 32-bit input number.
            //
            return _bitcounts[value & 65535] + _bitcounts[(value >> 16) & 65535];
        }
    }
}
