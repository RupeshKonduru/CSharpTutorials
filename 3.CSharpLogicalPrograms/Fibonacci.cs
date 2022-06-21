using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class Fibonacci
    {
        public static void FibonacciSeries(int firstNumber, int secondNumber, int counter, int number)
        {
            Console.Write(firstNumber + " ");
            if (counter < number)
            {
                FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);
            }
        }
        private static int NthFibonacciNumbers(int number)
        {
            if ((number == 0) || (number == 1))
            {
                return number;
            }
            else
            {
                return (NthFibonacciNumbers(number - 1) + NthFibonacciNumbers(number - 2));
            }
        }
        private static int NthFibonacciNumber(int number)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber = 0;
            // To return the first Fibonacci number  
            if (number == 0)
                return firstNumber;
            for (int i = 2; i <= number; i++)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            return secondNumber;
        }
        public static void Main()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write(firstNumber + " " + SecondNumber + " ");
                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }

            //Method 2
            Console.Write("Please enter the Length of the Fibonacci Series : ");
            int number = int.Parse(Console.ReadLine());
            FibonacciSeries(0, 1, 1, number);

            //Method 3
            Console.Write("Please enter the Nth number of the Fibonacci Series : ");
            int NthNumber = int.Parse(Console.ReadLine());
            //Decrement the Nth Number by 1. This is because the series starts with 0
            NthNumber = NthNumber - 1;
            Console.Write(NthFibonacciNumbers(NthNumber));

            //Method 3b
            Console.Write("Please enter the Nth number of the Fibonacci Series : ");
            int NthNumbers = int.Parse(Console.ReadLine());
            //Decrement the Nth Number by 1. This is because the series starts with 0
            NthNumbers = NthNumber - 1;
            Console.Write(NthFibonacciNumber(NthNumbers));


            //Method 4
            Console.Write("Enter the number upto which print the Fibonacci series : ");
            number = int.Parse(Console.ReadLine());
            //First print first and second number
            Console.Write(firstNumber + " " + SecondNumber + " ");
            nextNumber = firstNumber + SecondNumber;
            //Starts the loop from 2 because 0 and 1 are already printed
            for (int i = 2; nextNumber < number; i++)
            {
                Console.Write(nextNumber + " ");
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
                nextNumber = firstNumber + SecondNumber;
            }
            Console.ReadKey();
        }
    }
}
