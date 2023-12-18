using Getri_CodeFirst_MVC_EntityFramework.Models;
using Getri_CodeFirst_MVC_EntityFramework.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Getri_CodeFirst_MVC_EntityFramework.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository iemployeeRepository;

        public EmployeeController(IEmployeeRepository iemployeeRepository)
        {
            this.iemployeeRepository = iemployeeRepository;
        }

        public IActionResult Index()
        {

            List<Employee> lstemployee=iemployeeRepository.GetAllEmployees();
            return View(lstemployee);
        }

        public IActionResult Create() { return View("~/Views/Employee/CreateEmployee.cshtml"); }

       
        [HttpPost]
        public IActionResult CreateEmployee(Employee  employee) {
            var result =iemployeeRepository.CreateEmployee(employee);
            return RedirectToAction("Index");
        
        }

        public IActionResult Edit(int id) { 
            return View("~/Views/Employee/UpdateEmployee.cshtml", iemployeeRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var result=iemployeeRepository.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) { return View("~/Views/Employee/DeleteEmployee.cshtml",iemployeeRepository.GetById(id)); }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteEmployee(int id)
        {
            var result = iemployeeRepository.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) { return View("~/Views/Employee/GetEmployee.cshtml",iemployeeRepository.GetById(id)); }
        public IActionResult GetEmployee(int id) { 
          var result=iemployeeRepository.GetById(id);
            return RedirectToAction("Index");
        }
    }
}
