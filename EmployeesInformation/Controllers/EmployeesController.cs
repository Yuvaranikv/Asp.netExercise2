using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace EmployeesInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeDataStore _employeedataStore;

        public EmployeesController()
        {
            _employeedataStore = new EmployeeDataStore();
        }

        [HttpGet] // GET: api/employees
        public JsonResult GetEmployees()
        {
            var employees = _employeedataStore.Employees;
            return new JsonResult(employees);
        }

        [HttpGet("{id}")]
        public JsonResult GetEmployee(int id)
        {
            var employees = _employeedataStore.Employees.FirstOrDefault(e => e.Id == id);
            if (employees == null)
            {
                return new JsonResult(new { message = "employee not found" }) { StatusCode = 404 };
            }
            return new JsonResult(employees);
        }
    }
}
