using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    class AdapterDesignPattern
    {
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
            public decimal Salary { get; set; }
            public Employee(int id, string name, string designation, decimal salary)
            {
                ID = id;
                Name = name;
                Designation = designation;
                Salary = salary;
            }
        }
        public class ThirdPartyBillingSystem
        {
            //ThirdPartyBillingSystem accepts employees information as a List to process each employee salary
            public static void ProcessSalary(List<Employee> listEmployee)
            {
                foreach (Employee employee in listEmployee)
                {
                    Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
                }
            }
        }
        public interface ITarget
        {
            void ProcessCompanySalary(string[,] employeesArray);
        }
        public class EmployeeAdapter : ITarget
        {
            ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

            public void ProcessCompanySalary(string[,] employeesArray)
            {
                string Id = null;
                string Name = null;
                string Designation = null;
                string Salary = null;
                List<Employee> listEmployee = new List<Employee>();
                for (int i = 0; i < employeesArray.GetLength(0); i++)
                {
                    for (int j = 0; j < employeesArray.GetLength(1); j++)
                    {
                        if (j == 0)
                        {
                            Id = employeesArray[i, j];
                        }
                        else if (j == 1)
                        {
                            Name = employeesArray[i, j];
                        }
                        else if (j == 1)
                        {
                            Designation = employeesArray[i, j];
                        }
                        else
                        {
                            Salary = employeesArray[i, j];
                        }
                    }
                    listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
                }
                Console.WriteLine("Adapter converted Array of Employee to List of Employee");
                Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
                ThirdPartyBillingSystem.ProcessSalary(listEmployee);
            }
        }
        class Adapter
        {
            static void Main(string[] args)
            {
                string[,] employeesArray = new string[5, 4]
                {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
                };

                ITarget target = new EmployeeAdapter();
                Console.WriteLine("HR system passes employee string array to Adapter\n");
                target.ProcessCompanySalary(employeesArray);
                Console.Read();
            }
        }

    }
}
