using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprOOPS
{
    public class OldClass
    {
        public int x = 100;
        public void Test1()
        {
            Console.WriteLine("Method one: " + this.x);
        }
        public void Test2()
        {
            Console.WriteLine("Method two: " + this.x);
        }
    }
    public static class ExtensionMethod
    {
        public static void Text3(this OldClass O)
        {
            Console.WriteLine("Method Three");
        }
        public static void Text4(this OldClass O, int x)
        {
            Console.WriteLine("Method Four: " + x);
        }
        public static void Text5(this OldClass O)
        {
            Console.WriteLine("Method Five:" + O.x);
        }
        static void Main(string[] args)
        {
            OldClass obj = new OldClass();
            obj.Test1();
            obj.Test2();
            //Calling exrension methods
            obj.Text3();
            obj.Text4(10);
            obj.Text5();
            Console.ReadLine();
        }
    }
}
