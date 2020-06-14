using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public sealed class SingletonThreadSafe
    {
        private static int counter = 0;
        private static SingletonThreadSafe instance = null;
        public static SingletonThreadSafe GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonThreadSafe();
                return instance;
            }
        }
        private SingletonThreadSafe()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        /*
         * 
         * Implemeting Thread Safe with Lock Demo, Uncomment to Run
         *
         */

        //private static int counter = 0;
        //private static readonly object Instancelock = new object();
        //private SingletonThreadSafe()
        //{
        //    counter++;
        //    Console.WriteLine("Counter Value " + counter.ToString());
        //}
        //private static SingletonThreadSafe instance = null;

        //public static SingletonThreadSafe GetInstance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (Instancelock)
        //            {
        //                if (instance == null)
        //                {
        //                    instance = new SingletonThreadSafe();
        //                }
        //            }
        //        }
        //        return instance;
        //    }
        //}
        //public void PrintDetails(string message)
        //{
        //    Console.WriteLine(message);
        //}
    }
    class SingletonThreadSafePattern
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
            Console.ReadLine();
        }
        private static void PrintTeacherDetails()
        {
            SingletonThreadSafe fromTeacher = SingletonThreadSafe.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            SingletonThreadSafe fromStudent = SingletonThreadSafe.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
