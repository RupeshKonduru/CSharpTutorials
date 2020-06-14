using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public abstract class HouseTemplate
    {
        // Template method defines the sequence for building a house
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
            Console.WriteLine("House is built");
        }
        // Methods to be implemented by subclasses
        protected abstract void BuildFoundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }
    public class ConcreteHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods and sand");
        }
        protected override void BuildPillars()
        {
            Console.WriteLine("Building Concrete Pillars with Cement and Sand");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Concrete Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Concrete Windows");
        }
    }
    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods, wood and sand");
        }
        protected override void BuildPillars()
        {
            Console.WriteLine("Building wood Pillars with wood coating");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Wood Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Wood Windows");
        }
    }
    class TemplateDesignPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Build a Concrete House\n");
            HouseTemplate houseTemplate = new ConcreteHouse();
            // call the template method
            houseTemplate.BuildHouse();
            Console.WriteLine();
            Console.WriteLine("Build a Wooden House\n");
            houseTemplate = new WoodenHouse();
            // call the template method
            houseTemplate.BuildHouse();
            Console.Read();
        }
    }
}
