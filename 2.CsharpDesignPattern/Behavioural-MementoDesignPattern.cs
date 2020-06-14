using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public class LCDTV
    {
        public string Size { get; set; }
        public string Price { get; set; }
        public bool USBSupport { get; set; }
        public LCDTV(string Size, string Price, bool USBSupport)
        {
            this.Size = Size;
            this.Price = Price;
            this.USBSupport = USBSupport;
        }
        public string GetDetails()
        {
            return "LCDTV [Size=" + Size + ", Price=" + Price + ", USBSupport=" + USBSupport + "]";
        }
    }
    public class Memento
    {
        public LCDTV LCDTV { get; set; }
        public Memento(LCDTV LCDTV)
        {
            this.LCDTV = LCDTV;
        }
        public string GetDetails()
        {
            return "Memento [LCDTV=" + LCDTV.GetDetails() + "]";
        }
    }
    public class Caretaker
    {
        private List<Memento> LCDTVList = new List<Memento>();
        public void AddMemento(Memento m)
        {
            LCDTVList.Add(m);
            Console.WriteLine("LED TV's snapshots Maintained by CareTaker :" + m.GetDetails());
        }
        public Memento GetMemento(int index)
        {
            return LCDTVList[index];
        }
    }
    public class Originator
    {
        public LCDTV LCDTV;

        public Memento CreateMemento()
        {
            return new Memento(LCDTV);
        }
        public void SetMemento(Memento memento)
        {
            LCDTV = memento.LCDTV;
        }
        public string GetDetails()
        {
            return "Originator [LCDTV=" + LCDTV.GetDetails() + "]";
        }
    }
    class MementoDesignPattern
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.LCDTV = new LCDTV("42 inch", "60000Rs", false);

            Caretaker caretaker = new Caretaker();
            caretaker.AddMemento(originator.CreateMemento());
            originator.LCDTV = new LCDTV("46 inch", "80000Rs", true);
            caretaker.AddMemento(originator.CreateMemento());
            originator.LCDTV = new LCDTV("50 inch", "100000Rs", true);

            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.WriteLine("\nOriginator restoring to 42 inch LED TV");
            originator.LCDTV = caretaker.GetMemento(0).LCDTV;
            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.ReadKey();
        }
    }
}
