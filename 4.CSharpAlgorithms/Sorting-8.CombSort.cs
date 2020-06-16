using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class Sorting_CombSort
    {
        public static void CombSort()
        {
            int[] data = { 297, 183, 464 };
            double gap = data.Length;
            bool swaps = true;

            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swaps = false;

                while (i + gap < data.Length)
                {
                    int igap = i + (int)gap;

                    if (data[i] > data[igap])
                    {
                        int temp = data[i];
                        data[i] = data[igap];
                        data[igap] = temp;
                        swaps = true;
                    }

                    ++i;
                }
            }
        }
        static void Main(string[] args)
        {
            Sorting_CombSort.CombSort();
            Console.ReadLine();
        }
    }
}
