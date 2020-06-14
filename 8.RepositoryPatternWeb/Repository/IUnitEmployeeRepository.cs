using RepositoryPatternWeb.DataAccess;
using RepositoryPatternWeb.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWeb.Repository
{
    public interface IUnitEmployeeRepository : IUnitGenericRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesByGender(string Gender);
        IEnumerable<Employee> GetEmployeesByDepartment(string Dept);
    }
}
