using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprOOPS
{
    public class SealedClassAndSealedMethod
    {
        protected int Eid, Eage;
        protected string Ename, Eaddress;
        public virtual void GetEmployeeData()
        {
            Console.WriteLine("ENTER EMPLOYEE DETAILS:");
            Console.WriteLine("ENTER THE ID");
            Eid = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE NAME");
            Ename = Console.ReadLine();
            Console.WriteLine("ENTER THE ADDRESS");
            Eaddress = Console.ReadLine();
            Console.WriteLine("ENTER THE AGE");
            Eage = int.Parse(Console.ReadLine());
        }
        public virtual void DisplayEmployeeData()
        {
            Console.WriteLine("\nEMPLOEE DETAILS ARE:");
            Console.WriteLine("EMPLOYEE ID IS: " + Eid);
            Console.WriteLine("EMPLOYEE NAME IS: " + Ename);
            Console.WriteLine("EMPLOYEE ADDRESS IS:" + Eaddress);
            Console.WriteLine("EMPLOYEE AGE IS : " + Eage);
        }
    }
    public sealed class Manager : SealedClassAndSealedMethod
    {
        double Bonus, CA;
        public override void GetEmployeeData()
        {
            Console.WriteLine("ENTER MANAGER DETAILS:");
            Console.WriteLine("ENTER THE ID");
            Eid = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE NAME");
            Ename = Console.ReadLine();
            Console.WriteLine("ENTER THE BONUS");
            Bonus = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE CA");
            CA = Convert.ToDouble(Console.ReadLine());
        }
        public override void DisplayEmployeeData()
        {
            Console.WriteLine("MANAGER DETAILS ARE:");
            Console.WriteLine("EMPLOYEE ID IS: " + Eid);
            Console.WriteLine("EMPLOYEE NAME IS: " + Ename);
            Console.WriteLine("MANAGER BONUS IS: " + Bonus);
            Console.WriteLine("MANAGER CA IS : " + CA);
        }
        static void Main(string[] args)
        {
            Manager m1 = new Manager();
            m1.GetEmployeeData();
            m1.DisplayEmployeeData();
            Console.ReadKey();
        }
    }
}
