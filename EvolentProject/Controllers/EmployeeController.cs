using Evolent.DomainLayer.Data;
using Evolent.DomainLayer.Models;
using Evolent.ServiceLayer.ICustomServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EvolentProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ICustomService<Employee> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        public EmployeeController(ICustomService<Employee> customService,
            ApplicationDbContext applicationDbContext)
        {
            _customService = customService;
            _applicationDbContext = applicationDbContext;
        }

        
        [HttpGet(nameof(GetAllEmployee))]
        public IActionResult GetAllEmployee()
        {
            var obj = _customService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpPost(nameof(CreateEmployee))]
        public IActionResult CreateEmployee(Employee employee)
        {
            if (employee != null)
            {
                _customService.Insert(employee);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }

        [HttpPost(nameof(UpdateEmployee))]
        public IActionResult UpdateEmployee(Employee employee)
        {
            if (employee != null)
            {
                _customService.Update(employee);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpDelete(nameof(DeleteEmployee))]
        public IActionResult DeleteEmployee(Employee employee)
        {
            if (employee != null)
            {
                _customService.Delete(employee);
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}
