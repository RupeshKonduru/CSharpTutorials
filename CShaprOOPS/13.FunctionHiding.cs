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
    class FunctionHide: FunctionHiding
    {
        public new void display()
        {
            Console.WriteLine("Sub class display method");
        }
        static void Main(string[] args)
        {
            FunctionHide obj = new FunctionHide();
            obj.display();
            Console.ReadKey();
        }
    }
   
}
