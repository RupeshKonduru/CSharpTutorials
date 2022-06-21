using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class BinaryTODecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Decimal Value : {decimalValue} ");

            // MethodAccessException 2
            Console.Write("Enter the Binary Number : ");
            int binaryNumberEx = int.Parse(Console.ReadLine());
            int decimalValueEx = Convert.ToInt32(binaryNumberEx.ToString(), 2);
            Console.Write($"Decimal Value : {decimalValueEx} ");

            Console.ReadKey();
        }
    }
}
