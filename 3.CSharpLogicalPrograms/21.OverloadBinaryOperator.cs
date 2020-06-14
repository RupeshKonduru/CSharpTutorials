using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class OverloadBinaryOperator
    {
        //declare integer data member
        private int val;

        //initialize data members
        public OverloadBinaryOperator(int val)
        {
            this.val = val;

        }

        //Overload binary minus operator
        public static OverloadBinaryOperator operator -(OverloadBinaryOperator S1, OverloadBinaryOperator S2)
        {
            OverloadBinaryOperator temp = new OverloadBinaryOperator(0);

            temp.val = S1.val - S2.val;

            return temp;
        }

        //Overload binary multiply operator
        public static OverloadBinaryOperator operator *(OverloadBinaryOperator S1, OverloadBinaryOperator S2)
        {
            OverloadBinaryOperator temp = new OverloadBinaryOperator(0);

            temp.val = S1.val * S2.val;

            return temp;
        }

        //Overload binary minus operator
        public static OverloadBinaryOperator operator /(OverloadBinaryOperator S1, OverloadBinaryOperator S2)
        {
            OverloadBinaryOperator temp = new OverloadBinaryOperator(0);

            temp.val = S1.val / S2.val;

            return temp;
        }


        public void PrintValues()
        {
            Console.WriteLine("Values of val: " + val);
            Console.WriteLine();

        }
    }

    class OverloadBinaryOperators
    {
        static void Main(string[] args)
        {
            OverloadBinaryOperator S1 = new OverloadBinaryOperator(20);
            OverloadBinaryOperator S2 = new OverloadBinaryOperator(10);

            OverloadBinaryOperator S3 = new OverloadBinaryOperator(0);

            S3 = S1 - S2;
            S3.PrintValues();

            S3 = S1 * S2;
            S3.PrintValues();

            S3 = S1 / S2;
            S3.PrintValues();
        }
    }
}
