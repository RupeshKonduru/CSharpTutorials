using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public interface IComponent
    {
        void DisplayPrice();
    }
    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Leaf(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name + " : " + Price);
        }
    }
    public class Composite : IComponent
    {
        public string Name { get; set; }
        List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            this.Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name);
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }
    }
    public class CompositePattern
    {
        static void Main(string[] args)
        {
            //Creating Leaf Objects
            IComponent hardDisk = new Leaf("Hard Disk", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 2000);
            IComponent mouse = new Leaf("Mouse", 2000);
            IComponent keyboard = new Leaf("Keyboard", 2000);
            //Creating composite objects
            Composite motherBoard = new Composite("Peripherals");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");
            //Creating tree structure
            //Ading CPU and RAM in Mother board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);
            //Ading mother board and hard disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);
            //Ading mouse and keyborad in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);
            //Ading cabinet and peripherals in computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);
            //To display the Price of Computer
            computer.DisplayPrice();
            Console.WriteLine();
            //To display the Price of Keyboard
            keyboard.DisplayPrice();
            Console.WriteLine();
            //To display the Price of Cabinet
            cabinet.DisplayPrice();
            Console.Read();
        }
    }
}
