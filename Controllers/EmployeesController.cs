using CRUDWITHREPOSITORY.Model;
using CRUDWITHREPOSITORY.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWITHREPOSITORY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet("id")]
        public ActionResult<Employee> GetEmployeeById([FromQuery] int id)
        {
            var employee = _employeeRepository.GetEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost]
        public ActionResult<Employee> CreateEmployee([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model Object");
            }
            _employeeRepository.CreateEmployee(employee);
            return Ok(CreatedAtRoute("EmpId", new { id = employee.EmpId }, employee));
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee Object Id Null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Model Object");
            }
            var dbemp = _employeeRepository.GetEmployee(id);
            if (!dbemp.EmpId.Equals(id)) 
            {
                return NotFound();
            }
            _employeeRepository.UpdateEmployee(employee);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var dbemp = _employeeRepository.GetEmployee(id);
            if (!dbemp.EmpId.Equals(id))
            {
                return NotFound();
            }
            _employeeRepository.DeleteEmployee(dbemp);
            return NoContent();
        }
    }
}
