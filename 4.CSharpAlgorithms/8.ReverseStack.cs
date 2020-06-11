using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    //Reverse a stack
    public static class ReverseStack
    {
        //This method returns a stack
        public static Stack Reverse(Stack input)
        {
            //Declare another stack to store the values from the passed stack
            Stack temp = new Stack();

            //While the passed stack isn't empty, pop elements from the passed stack onto the temp stack
            while (input.Count != 0)
                temp.Push(input.Pop());

            return temp;
        }
        
    }
    class ReverseAStack
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(8);
            stack.Push(2);

            ReverseStack.Reverse(stack);
        }
    }
}
