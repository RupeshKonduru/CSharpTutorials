using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPS
{
    class ClassAndObjects
    {
        public ClassAndObjects()
        {
            Console.WriteLine("This is the ClassAndObjects default consturctor ");
        }
        public ClassAndObjects(string param)
        {
            Console.WriteLine(String.Format("This is the ClassAndObjects parameterized consturctor with value  {0}", param));
        }

        public void ClassAndObjectsMethod1()
        {
            Console.WriteLine("This is object call for ClassAndObjectsMethod");
        }

        //Static Method does'nt require object for invocation
        public static void ClassAndObjectsMethod2()
        {
            Console.WriteLine("This is static ClassAndObjectsMethod");
        }
        public static void Main(string[] args)
        {
            //Crating Objects for class with consturctor and static methods
            ClassAndObjects.ClassAndObjectsMethod2();
            ClassAndObjects obj = new ClassAndObjects();
            obj.ClassAndObjectsMethod1();
            ClassAndObjects obj1 = new ClassAndObjects("Value1");
            obj1.ClassAndObjectsMethod1();
            Console.ReadLine();
        }
    }
    
}


