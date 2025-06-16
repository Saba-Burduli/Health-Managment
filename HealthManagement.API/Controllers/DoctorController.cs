using HealthManagement.SERVICE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorService _doctorService;

        public DoctorController(DoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        
        [HttpGet("GetALlDoctorsAsync")]
        public async Task<IActionResult> GetALlDoctorsAsync()
        {
            if (ModelState.IsValid)
            {
                var doctor = await _doctorService.GetALlDoctorsAsync();
                if (doctor==null)
                {
                    return BadRequest("Doctors cannot be null");
                }

                return Ok("Doctors founded Successfuly");
            }

            return BadRequest("Doctors not found");
        }
        
        [HttpGet("GetDoctorByIdAsync")]
        public async Task<IActionResult> GetDoctorByIdAsync(int doctorId)
        {
            if (ModelState.IsValid)
            {
                var doctor = await _doctorService.GetDoctorByIdAsync(doctorId);
                if (doctor==null || doctorId ==null)
                {
                    return BadRequest("doctorId cannot be null");
                }

                return Ok();
            }

            return BadRequest();
        }
    }
}
