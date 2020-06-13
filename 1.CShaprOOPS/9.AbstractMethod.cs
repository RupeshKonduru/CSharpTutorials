using System;

namespace CShaprOOPS
{
    abstract class AbstractMethod
    {
        protected int EmpId, EAge=0;
        protected string EName, EAddress="";
        public abstract void GetEmpData();
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Employee Id Is: " + this.EmpId);
            Console.WriteLine("Employee Name Is: " + this.EName);
            Console.WriteLine("Employee Address Is: " + EAddress);
            Console.WriteLine("Employee Age is: " + this.EAge);
        }
        public AbstractMethod()
        {
            Console.WriteLine("ABSTRACT CLASS CONSTRUCTOR");
        }
    }
    class ClsManager : AbstractMethod
    {
        double Bonus, CA;
        public override void GetEmpData()
        {
            Console.WriteLine("ENTER MANAGER DETAILS");
            Console.WriteLine("Enter the Manager Id: ");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Manager name: ");
            EName = Console.ReadLine();
            Console.WriteLine("Enter the manager Bonus: ");
            Bonus = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Manager CA: ");
            CA = double.Parse(Console.ReadLine());
        }
        public override void DisplayEmpData()
        {
            Console.WriteLine("manager id is: " + EmpId);
            Console.WriteLine("manager name is: " + EName);
            Console.WriteLine("manager bonus is: " + Bonus);
            Console.WriteLine("Manager CA is: " + CA);
        }
        static void Main(string[] args)
        {
            ClsManager cm = new ClsManager();
            cm.GetEmpData();
            cm.DisplayEmpData();
            Console.ReadKey();
        }
    }
}
