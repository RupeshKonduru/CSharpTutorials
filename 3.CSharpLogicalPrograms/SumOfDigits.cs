using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    public class SumOfDigits
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, reminder;

            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }

            Console.WriteLine($"The Sum of Digits is : {sum}");

            //Method 2
            Console.Write("Enter the Number : ");
            int sums = SumOfDigit(number);
            Console.WriteLine($"The Sum of Digits is : {sums}");

            //Method 3
            Console.Write("Enter the Number : ");
            int sumRes = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();

            Console.WriteLine($"The Sum of Digits is : {sumRes}");

            Console.ReadKey();
        }
        static int SumOfDigit(int number)
        {
            if (number != 0)
            {
                return (number % 10 + SumOfDigit(number / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}
