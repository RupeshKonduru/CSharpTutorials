using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprOOPS
{
    class ClassAndObjects
    {
        public ClassAndObjects()
        {
            Console.WriteLine("This is the ClassAndObjects default consturctor ");
        }
        public ClassAndObjects(string param)
        {
            Console.WriteLine(String.Format("This is the ClassAndObjects parameterized consturctor with value  {0}",param));
        }

        public void ClassAndObjectsMethod1()
        {
            Console.WriteLine("This is object call for ClassAndObjectsMethod");
        }

        public static void ClassAndObjectsMethod2()
        {
            Console.WriteLine("This is static ClassAndObjectsMethod");
        }
    }
}
