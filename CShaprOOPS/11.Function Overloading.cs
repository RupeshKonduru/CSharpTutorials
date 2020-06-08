using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprOOPS
{
    class FunctionOverloading
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
    }
    //Inheritance Overloading
    class ADD2 : FunctionOverloading
    {
        public void add(string s1, string s2)
        {
            Console.WriteLine(s1 + s2);
        }
        static void Main(string[] args)
        {
            ADD2 obj = new ADD2();
            obj.add(10, 20);
            obj.add(10.5f, 20.5f);
            obj.add("pranaya", "kumar");
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}
