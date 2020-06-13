using RepositoryPatternWeb.DataAccess;
using RepositoryPatternWeb.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWeb.Repository
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        //IEnumerable<Employee> GetAll();
        //Employee GetById(int EmployeeID);
        //void Insert(Employee employee);
        //void Update(Employee employee);
        //void Delete(int EmployeeID);
        //void Save();

        IEnumerable<Employee> GetEmployeesByGender(string Gender);
        IEnumerable<Employee> GetEmployeesByDepartment(string Dept);
    }
}
