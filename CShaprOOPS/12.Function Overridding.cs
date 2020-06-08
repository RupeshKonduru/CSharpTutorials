using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprOOPS
{
    class FunctionOverridding
    {
        public virtual void show()
        {
            Console.WriteLine("Super class show method");
        }
    }
    class Class2 : FunctionOverridding
    {
        public override void show()
        {
            //If static class or method used then no base and this keyword can be used
            base.show();
            Console.WriteLine("Sub class override show method");
        }
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.show();
            Console.ReadKey();
        }
    }
}
