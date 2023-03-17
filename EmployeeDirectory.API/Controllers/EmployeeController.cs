using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using System.Security;

namespace EmployeeDirectory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllEmployees()
        {
            return Ok(_employeeService.GetAllEmployees());
        }

        [HttpGet("getEmployee/{id}")]
        public IActionResult GetEmployee(string id)
        {
            var emp= _employeeService.GetEmployee(id);
            if (emp!=null)
                return Ok();
            return NotFound();
        }

        [HttpPost()]
        public IActionResult AddEmployee(Employee employee)
        {
            return Ok(_employeeService.AddEmployee(employee));
        }

        [HttpDelete()]
        public IActionResult RemoveEmployee(string id)
        {
            return Ok(_employeeService.RemoveEmployee(id));
        }

        [HttpPut()]

        public IActionResult UpdateEmployee(Employee employee)
        {
            return Ok(_employeeService.UpdateEmployee(employee));
        }
    }
}
