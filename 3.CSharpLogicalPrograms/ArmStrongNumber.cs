using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class ArmStrongNumber
    {
        static bool IsArmstrongNumber(int number)
        {
            int sum = 0;
            int temporaryNumber = number;
            int temp = 0;
            int length = number.ToString().Length;
            while (number != 0)
            {
                temp = number % 10;
                number = number / 10;
                sum += (int)Math.Pow(temp, length);
            }

            if (sum == temporaryNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int i = 0;
            int digitCount = 0;
            int[] digitArray = new int[10];
            double sum = 0;
            //Step1: Take the input
            Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            //Step3: Store the number in a temporary variable
            int temporaryNumber = number;
            //Step3: Find the total number of digits in number as well as
            //Store each each digit in the digit array
            while (number > 0)
            {
                digitArray[i++] = number % 10;
                number = number / 10;
                digitCount++;
            }
            //Step4: Calculate the result
            for (i = 0; i < digitCount; i++)
            {
                sum += Math.Pow(digitArray[i], digitCount);
            }
            //Step5: Check whether it is prime number or not
            if (sum == temporaryNumber)
            {
                Console.WriteLine($"The Number {temporaryNumber} is armstrong");
            }
            else
            {
                Console.WriteLine($"The Number {temporaryNumber} is not armstrong");
            }

            //Method2
            Console.Write("Enter the Start Number : ");
            int StartNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the End Number : ");
            int EndNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Armstrong Numbers between {StartNumber} and {EndNumber} are : ");
            for (int j = StartNumber; j <= EndNumber; j++)
            {
                if (IsArmstrongNumber(j))
                    Console.WriteLine(j);
            }

            Console.ReadLine();
        }
    }
}
