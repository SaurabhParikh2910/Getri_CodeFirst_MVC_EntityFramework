using System.ComponentModel.DataAnnotations;

namespace Getri_CodeFirst_MVC_EntityFramework.Models
{
    public class Employee
    {
        [Key]
            public  int EmpId {  get; set; }    
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int EmpGender { get; set; }
        public string Contact {  get; set; }    
    }
}
