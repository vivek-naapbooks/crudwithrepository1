using System.ComponentModel.DataAnnotations;

namespace CRUDWITHREPOSITORY.Model
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string JoinDate { get; set; }
    }
}
