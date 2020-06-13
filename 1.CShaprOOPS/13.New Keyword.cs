using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPS
{
    class Class1
    {
        public virtual void Display()
        {
            Console.WriteLine("Super class display method");
        }
    }
    class NewKeyWordCLass : Class1
    {
        public override void Display()
        {
            Console.WriteLine("Sub class display method");
        }
        static void Main()
        {
            //NewKeyword
            //By default super class is invoked if no New or Override is used
            //New  - When we create an obj for base class pointing to child class,only the base class method is invocked
            //Override  - When we create an obj for base class pointing to child class,only the child class method is invocked
            NewKeyWordCLass obj = new NewKeyWordCLass();
            ((Class1)obj).Display();  // 
            Class1 newKeyWordObj = new NewKeyWordCLass();
            newKeyWordObj.Display();
            Console.ReadKey();
        }
    }
    
    
}
