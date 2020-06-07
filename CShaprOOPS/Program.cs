using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprOOPS
{
    class Program
    {
        static void Main(string[] args)
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
