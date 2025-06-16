using HealthManagement.Infrastructure.Entities;
using HealthManagement.SERVICE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Logging;

namespace HealthManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientService _patientService;
        
        public PatientController( PatientService patientService)
        {
            _patientService = patientService;
        }
        [HttpGet("GetALlPatientsAsync")]
       public async Task<IActionResult> GetALlPatientsAsync()
        {
            if (ModelState.IsValid)
            {
                var patient = await _patientService.GetALlPatientsAsync();
                
                if (patient == null)
                {
                    return NotFound("Patient not found");
                }
                
                return Ok();
            }
            return BadRequest("Patiend not found");
        }
       
        [HttpGet("GetPatientByIdAsync")]
        public async Task<IActionResult> GetPatientByIdAsync(int patientId)
        {
            if (ModelState.IsValid)
            {
                var patient = await _patientService.GetPatientByIdAsync(patientId);
                if (patient==null)
                {
                    return NotFound("Patient not found");
                }

                return Ok();
            }

            return BadRequest();
        }

        [HttpPost("AddPatientAsync")]
        public async Task<IActionResult> AddPatientAsync(Patient patient)
        {
            if (ModelState.IsValid)
            {
                var patientAdd = await _patientService.AddPatientAsync(patient);
                if (patientAdd==null)
                {
                    return BadRequest("patient not found");
                }

                return Ok("Patient Added Successfuly");
            }

            return BadRequest("Patient cannot Added");
        }

        [HttpPut("UpdatePatientAsync")]
        public async Task<IActionResult> UpdatePatientAsync(Patient patient)
        {
            if (ModelState.IsValid)
            {
                var patientUpdate = await _patientService.UpdatePatientAsync(patient);
                if (patientUpdate==null)
                {
                    return BadRequest("Patient cannot be null");
                }

                return Ok("Patient updated Successfuly");
            }
            return BadRequest("Patient cannot Updated");
        }
    }
}
