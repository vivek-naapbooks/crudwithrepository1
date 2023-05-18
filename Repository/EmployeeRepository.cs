using CRUDWITHREPOSITORY.Model;

namespace CRUDWITHREPOSITORY.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
        public void CreateEmployee()
        {
            throw new NotImplementedException();
        }
        public void UpdateEmployee(Employee employee)
        {
            Update(employee);
        }
        public void CreateEmployee(Employee employee)
        {
            Create(employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }
        public Employee GetEmployee(int id)
        {
            return FindbyCondition(e => e.EmpId == id).FirstOrDefault();
        }
    }
 }
