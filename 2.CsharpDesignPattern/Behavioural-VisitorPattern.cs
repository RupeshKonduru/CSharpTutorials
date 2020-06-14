using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
    public class Kid : IElement
    {
        public string KidName { get; set; }

        public Kid(string name)
        {
            KidName = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public interface IVisitor
    {
        void Visit(IElement element);
    }
    public class Doctor : IVisitor
    {
        public string Name { get; set; }
        public Doctor(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Doctor: " + this.Name + " did the health checkup of the child: " + kid.KidName);
        }
    }
    class Salesman : IVisitor
    {
        public string Name { get; set; }
        public Salesman(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Salesman: " + this.Name + " gave the school bag to the child: "
                            + kid.KidName);
        }
    }
    public class School
    {
        private static List<IElement> elements;
        static School()
        {
            elements = new List<IElement>
            {
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam")
            };
        }
        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in elements)
            {
                kid.Accept(visitor);
            }
        }
    }
    class VisitorDesignPattern
    {
        static void Main(string[] args)
        {
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);
            Console.WriteLine();
            var visitor2 = new Salesman("John");
            school.PerformOperation(visitor2);
            Console.Read();
        }
    }
}
