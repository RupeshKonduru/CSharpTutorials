using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprOOPS
{
    public partial class PartialEmployee
    {
        private string _firstName;
        private string _lastName;
        private double _salary;
        private string _gender;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
    public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine(@"Full Name is :  {0} {1}", _firstName, _lastName);
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine(@"First Name : {0}", _firstName);
            Console.WriteLine(@"Last Name : {0}", _lastName);
            Console.WriteLine(@"Gender : {0}", _gender);
            Console.WriteLine(@"Salary : {0}", _salary);
        }
        partial class PartialClass
        {
            // Declaration of the partial method.
            partial void PartialMethod();
            // A public method calling the partial method
            public void PublicMethod()
            {
                Console.WriteLine("Public Method Invoked");
                PartialMethod();
            }
        }
        static void Main(string[] args)
        {
            //Partial Class
            PartialEmployee emp = new PartialEmployee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            emp.Salary = 100000;
            emp.Gender = "Male";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();

            //Partial Methods
            PartialClass SC = new PartialClass();
            SC.PublicMethod();

            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}
