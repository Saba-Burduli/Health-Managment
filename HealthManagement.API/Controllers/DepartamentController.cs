using HealthManagement.SERVICE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentController : ControllerBase
    {
        private readonly DepartmentService _departmentService;

        public DepartamentController(DepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        
        [HttpGet("GetAllDepartmentsAsync")]
        public async Task<IActionResult> GetAllDepartmentsAsync()
        {
            if (ModelState.IsValid)
            {
                var departaments = await _departmentService.GetAllDepartmentsAsync();
                if (departaments==null)
                {
                    return BadRequest("Departaments cannot be null");
                }

                return Ok("All Departaments founded Successfuly");
            }
            
           return BadRequest();
        }
        
        [HttpGet("GetDepartmentByIdAsync")]
        public async Task<IActionResult> GetDepartmentByIdAsync(int departamentId)
        {
            if (ModelState.IsValid)
            {
                var departament = await _departmentService.GetDepartmentByIdAsync(departamentId);
                if (departament==null || departamentId==null)
                {
                    return BadRequest("Departament or departamentId  cannot be null");
                }
                return Ok("Found Departament by Id Successfuly");  
            }
            return BadRequest();
        }
        
    }
}
