using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace EmployeesInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeDataStore _employeeDataStore;

        public EmployeesController(EmployeeDataStore employeeDataStore)
        {
            _employeeDataStore = employeeDataStore;
        }

        [HttpGet] // GET: api/employees
        public async Task<JsonResult> GetEmployees()
        {
            var employees = await _employeeDataStore.GetEmployeesAsync();
            return new JsonResult(employees);
        }

        [HttpGet("{id}")] // GET: api/employees/{id}
        public async Task<JsonResult> GetEmployee(int id)
        {
            var employee = await _employeeDataStore.GetEmployeeByIdAsync(id);
            if (employee == null)
            {
                return new JsonResult(new { message = "Employee not found" }) { StatusCode = 404 };
            }
            return new JsonResult(employee);
        }
    }
}