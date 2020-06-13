using System;

namespace ConstructorDemo
{
    class Example
    {
        int i;
        static int j;
        public Example()
        {
            i = 100;
        }
        ~Example()
        {
            Console.WriteLine("object is destroyed");
        }
        static Example()
        {
            j = 100;
        }
        public void Display()
        {
            Console.WriteLine("value of i : " + i);
            i++;
            Console.WriteLine("value of j : " + j);
            j++;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Example e1 = new Example();
            e1.Display();//i=100,j=100
            e1.Display();//j=101,i=100
            Example e2 = new Example();
            e2.Display();//j=102,i=101
            e2.Display();//j=103,i=101

            e1 = null;
            e2 = null;
            GC.Collect();
            
            Console.ReadKey();
        }
    }
}