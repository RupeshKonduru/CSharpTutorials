using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPS
{
    public interface Interface1
    {
        void Test();
        void Show();
    }
    public interface Interface2
    {
        void Test();
        void Show();
    }
    class Interface : Interface1, Interface2
    {
        //public modifier is not allowed  with fully qualified name implement interface
        void Interface1.Test()
        {
            Console.WriteLine("Test mthod of interafce1 is implemented");
        }
        void Interface1.Show()
        {
            Console.WriteLine("Show mwthod of interafce1 is implemented");
        }
        void Interface2.Test()
        {
            Console.WriteLine("Test mthod of interface2 is implemented");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Show mwthod of interafce2 is implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Interface obj = new Interface();
            //obj.Test();  //not possible
            //obj.Show();  //not possible
            ((Interface1)obj).Test();
            ((Interface1)obj).Show();

            Interface1 obj1 = new Interface();
            obj1.Test();
            obj1.Show();
            Interface2 obj2 = new Interface();
            obj2.Test();
            obj2.Show();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}
