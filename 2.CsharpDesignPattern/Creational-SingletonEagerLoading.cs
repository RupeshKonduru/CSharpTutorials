using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public sealed class SingletonEagerLoading
    {
        private static int counter = 0;
        private SingletonEagerLoading()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static readonly SingletonEagerLoading singleInstance = new SingletonEagerLoading();

        public static SingletonEagerLoading GetInstance
        {
            get
            {
                return singleInstance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
    class SingletonEagerLoad
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
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
