using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RepositoryPatternWeb.DataAccess;
using RepositoryPatternWeb.Repository;
using RepositoryPatternWeb.UnitGenericRepository;
using RepositoryPatternWeb.UnitOfWork;

namespace RepositoryPatternWeb.Controllers
{
    public class UnitEmployeeController : Controller
    {
        private UnitOfWork<EmployeeDBEntities> unitOfWork = new UnitOfWork<EmployeeDBEntities>();
        private UnitGenericRepository<Employee> repository;
        private IUnitEmployeeRepository employeeRepository;
        public UnitEmployeeController()
        {
            //If you want to use Generic Repository with Unit of work
            repository = new UnitGenericRepository<Employee>(unitOfWork);
            //If you want to use Specific Repository with Unit of work
            employeeRepository = new UnitEmployeeRepository(unitOfWork);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = repository.GetAll();
            //Using Specific Repository
            //var model = employeeRepository.GetEmployeesByDepartment(1);
            return View(model);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            try
            {
                unitOfWork.CreateTransaction();
                if (ModelState.IsValid)
                {
                    repository.Insert(model);
                    unitOfWork.Save();
                    //Do Some Other Task with the Database
                    //If everything is working then commit the transaction else rollback the transaction
                    unitOfWork.Commit();
                    return RedirectToAction("Index", "Employee");
                }
            }
            catch (Exception ex)
            {
                //Log the exception and rollback the transaction
                unitOfWork.Rollback();
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditEmployee(int EmployeeId)
        {
            Employee model = repository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                repository.Update(model);
                unitOfWork.Save();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            Employee model = repository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            Employee model = repository.GetById(EmployeeID);
            repository.Delete(model);
            unitOfWork.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
