using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPS
{
    class ClassAndObjects
    {
        int eid, age;
        string address, name;
        public ClassAndObjects()
        {
            try
            {
                Console.WriteLine("ENTER EMPLOYEE DETAILS");
                Console.WriteLine("Enter the employee id");
                this.eid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the employee age");
                this.age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the employee name");
                this.name = Console.ReadLine();
                Console.WriteLine("Enter the employee address:");
                this.address = Console.ReadLine();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /*Copy Constructor*/
        //The constructor which takes a parameter of the class type is called a copy constructor.
        //This constructor is used to copy one object data into another object. 
        //The main purpose of the copy constructor is to initialize a new object (instance) with
        //the values of an existing object (instance).
        public ClassAndObjects(ClassAndObjects tempobj)
        {
            this.eid = tempobj.eid;
            this.age = tempobj.age;
            this.name = tempobj.name;
            this.address = tempobj.address;
        }

        /*Static Constructor*/
        //one static constructor in a class, without any parameter,can only access the static members of the class.
        //should not be any access modifier in static constructor,class is static then we cannot create the object for the static class
        //Static constructor will be invoked only once i.e. at the time of first object creation of the class
        static int j;
        static ClassAndObjects()
        {
            j = 100;
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Employee id is:  " + this.eid);
            Console.WriteLine("Employee name is:  " + this.name);
            Console.WriteLine("Employee age is:  " + this.age);
            Console.WriteLine("Employee address is:  " + this.address);
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

            //Emp Details
            ClassAndObjects e1 = new ClassAndObjects();
            ClassAndObjects e2 = new ClassAndObjects(e1);
            e1.Display();
            e2.Display();
            Console.ReadLine();
        }
    }
    
}


