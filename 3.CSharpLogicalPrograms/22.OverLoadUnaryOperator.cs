using System;

namespace CSharpLogicalPrograms
{
    class OverLoadUnary
    {
        //declare integer data member
        private int val;

        //initialize data members
        public OverLoadUnary(int val)
        {
            this.val = val;
        }

        //Overload unary decrement operator
        public static OverLoadUnary operator --(OverLoadUnary S)
        {
            S.val = --S.val;
            return S;
        }

        //Overload unary increment operator
        public static OverLoadUnary operator ++(OverLoadUnary S)
        {
            S.val = ++S.val;
            return S;
        }

        public void PrintValues()
        {
            Console.WriteLine("Values of val: " + val);
            Console.WriteLine();
        }
    }

    class OverLoadUnaryOperator
    {
        static void Main(string[] args)
        {
            OverLoadUnary S = new OverLoadUnary(10);

            S++;
            S++;
            S++;
            S.PrintValues();

            S--;
            S--;
            S.PrintValues();
        }
    }
}
