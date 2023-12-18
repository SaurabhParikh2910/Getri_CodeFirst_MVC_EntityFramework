using Getri_CodeFirst_MVC_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace Getri_CodeFirst_MVC_EntityFramework.EntityFramework
{
    public class EmployeeDbContext:DbContext
    {
         public EmployeeDbContext(DbContextOptions options):base(options) 
        {

        }

        public DbSet<Employee> employees { get; set; }
    }
}
