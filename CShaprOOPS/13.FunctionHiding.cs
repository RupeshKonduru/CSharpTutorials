using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprOOPS
{
    class FunctionHiding
    {
        public void display()
        {
            Console.WriteLine("Super class display method");
        }
    }
    class ClassChild : FunctionHiding
    {
        public new void display()
        {
            Console.WriteLine("Sub class display method");
        }
        static void Main(string[] args)
        {
            ClassChild obj = new ClassChild();
            obj.display();
            Console.ReadKey();
        }
    }
   
}
