using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.Write($"Factorial of {number}  is: {factorial}");

            //Method 2
            Console.Write("Enter a Number : ");
            while (number != 1)
            {
                factorial = factorial * number;
                number = number - 1;
            }

            Console.Write($"Factorial is: {factorial}");

            //Method 3
            Console.Write("Enter a Number : ");
            long factorials = RecursiveFactorial(number);
            Console.Write($"Factorial of {number} is: {factorials}");
            
            //Method4
            Console.Write("Enter a Number : ");
            do
            {
                factorial = factorial * number;
                number--;
            } while (number > 0);
            Console.Write($"The Factorial is: {factorial}");

            Console.ReadLine();
        }
        static long RecursiveFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * RecursiveFactorial(number - 1);
            }
        }
    }
}
