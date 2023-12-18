using Getri_CodeFirst_MVC_EntityFramework.EntityFramework;
using Getri_CodeFirst_MVC_EntityFramework.Models;

namespace Getri_CodeFirst_MVC_EntityFramework.Repository
{
    public class EmployeeRepository : IEmployeeRepository

    {

        private readonly EmployeeDbContext employeeDbContext;

        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
                this.employeeDbContext = employeeDbContext;
        }
        public Employee CreateEmployee(Employee employee)
        {
            employeeDbContext.Add<Employee>(employee);
            employeeDbContext.SaveChanges();
            return employee;
        }

        public bool DeleteEmployee(int id)
        {
           var emp= employeeDbContext.employees.Find(id);

            var res=employeeDbContext.Remove(emp);
            employeeDbContext.SaveChanges();
            return res != null ? true : false;
        }

        public List<Employee> GetAllEmployees()
        {
           return employeeDbContext.employees.ToList();
        }

        public Employee GetById(int id)
        {
            return employeeDbContext.employees.Find(id); 
        }

        public Employee UpdateEmployee(Employee employee)
        {
            
            employeeDbContext.Update<Employee>(employee);
            employeeDbContext.SaveChanges();
            return employee;

        }
    }
}
