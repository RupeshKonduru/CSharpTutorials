using RepositoryPatternWeb.DataAccess;
using RepositoryPatternWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*
 * Below methods are added
 
Index(): This action method displays an Index view and passes a List of Employee entities as its model.
AddEmployee(): Displays the Add employee view.
AddEmployee(Employee model): Add Employee view submits data to this method. It receives the data as an Employee instance and then inserts an Employee using the repository.
EditEmployee(int EmployeeId): Displays the Edit Employee view. It accepts an Employee ID as the parameter and populates the Edit Employee view with the data of the existing Employee whose ID it accepts as the parameter.
EditEmployee(Employee model): Edit Employee view submits the data to this method. It receives the data as an Employee instance and then updates the Employee using the repository.
DeleteEmployee(int EmployeeId): Displays the Delete Employee view.
Delete(int EmployeeId): Delete Employee view submits the data to this action method. The action then deletes the Employee using the repository. 
*/
namespace RepositoryPatternWeb.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController()
        {
            _employeeRepository = new EmployeeRepository(new EmployeeDBEntities());
        }
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _employeeRepository.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(int EmployeeID)
        {
            var model = _employeeRepository.GetAll().Where(x => x.EmployeeID == EmployeeID).FirstOrDefault(); ;
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
            if (ModelState.IsValid)
            {
                _employeeRepository.Insert(model);
                _employeeRepository.Save();
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditEmployee(int EmployeeID)
        {
            Employee model = _employeeRepository.GetById(EmployeeID);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Update(model);
                _employeeRepository.Save();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeID)
        {
            Employee model = _employeeRepository.GetById(EmployeeID);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            _employeeRepository.Delete(EmployeeID);
            _employeeRepository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}