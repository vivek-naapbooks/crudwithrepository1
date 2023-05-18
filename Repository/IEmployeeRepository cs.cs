using CRUDWITHREPOSITORY.Model;

namespace CRUDWITHREPOSITORY.Repository
{
    public interface IEmployeeRepository : IRespositoryBase<Employee>
    {
        Employee GetEmployee(int id);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }

}
