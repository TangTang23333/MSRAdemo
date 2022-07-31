using Core.Model;
using Core.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }


        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("/employees")]
        public async Task<List<Employee>> GetAll()
        {
            return await this._employeeService
                .GetAllEmployees();
        }








    }
}
