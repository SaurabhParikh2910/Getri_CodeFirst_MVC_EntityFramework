using Getri_CodeFirst_MVC_EntityFramework.Models;

namespace Getri_CodeFirst_MVC_EntityFramework.Repository
{
    public interface IEmployeeRepository
    {

        List<Employee> GetAllEmployees();

         Employee GetById(int id);

         Employee CreateEmployee(Employee employee);
         Employee UpdateEmployee(Employee employee);
         bool DeleteEmployee(int id); 
    }
}
