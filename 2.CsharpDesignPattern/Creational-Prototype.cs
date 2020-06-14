using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    class PrototypeDesignPattern
    {
        static void Main(string[] args)
        {
            EmployeePrototype emp1 = new EmployeePrototype();
            emp1.Name = "Anurag";
            emp1.Department = "IT";
            EmployeePrototype emp2 = emp1.GetClone();
            emp2.Name = "Pranaya";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
            Console.Read();
        }
    }
    public class EmployeePrototype
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public EmployeePrototype GetClone()
        {
            return (EmployeePrototype)this.MemberwiseClone();
        }
    }
}
