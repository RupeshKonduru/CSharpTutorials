using RepositoryPatternWeb.DataAccess;
using RepositoryPatternWeb.GenericRepository;
using RepositoryPatternWeb.UnitGenericRepository;
using RepositoryPatternWeb.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryPatternWeb.Repository
{
    public class UnitEmployeeRepository : UnitGenericRepository<Employee>, IUnitEmployeeRepository
    {
        public UnitEmployeeRepository(IUnitOfWork<EmployeeDBEntities> unitOfWork)
            : base(unitOfWork)
        {
        }
        public UnitEmployeeRepository(EmployeeDBEntities context)
            : base(context)
        {
        }
        public IEnumerable<Employee> GetEmployeesByGender(string Gender)
        {
            return Context.Employees.Where(emp => emp.Gender == Gender).ToList();
        }
        public IEnumerable<Employee> GetEmployeesByDepartment(string Dept)
        {
            return Context.Employees.Where(emp => emp.Dept == Dept).ToList();
        }
    }
}