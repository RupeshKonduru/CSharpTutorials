using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public sealed class SingletonLazyLoading
    {
        private static int counter = 0;
        private SingletonLazyLoading()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static readonly Lazy<SingletonLazyLoading> Instancelock =
                    new Lazy<SingletonLazyLoading>(() => new SingletonLazyLoading());
        public static SingletonLazyLoading GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
    class SingletonLazyLoad
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
