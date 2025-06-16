using HealthManagement.SERVICE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HealthManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientDiagnosisController : ControllerBase
    {
        private readonly PatientDiagnosisService _patientDiagnosisService;

        public PatientDiagnosisController(PatientDiagnosisService patientDiagnosisService)
        {
            _patientDiagnosisService = patientDiagnosisService;
        }
      
        [HttpGet("GetAllPatientsDiagnosis")]
        public async Task<IActionResult> GetAllPatientsDiagnosis()
        {
            if (ModelState.IsValid)
            {
                var patientsDiagnosis = await _patientDiagnosisService.GetAllPatientsDiagnosis();
                if (patientsDiagnosis==null)
                {
                    return BadRequest("patientsDiagnosis cannot be null");
                }

                return Ok("All patients Diagnosis Founded");
            }

            return BadRequest("Patients Diagnosis not founded");
        }
        
        [HttpGet("GetPatientByDiagnosisIdAsync")]
        public async Task<IActionResult> GetPatientByDiagnosisIdAsync(int patientDiagnosisId)
        {
            if (ModelState.IsValid)
            {
                var patientsDiagnosis = _patientDiagnosisService.GetPatientByDiagnosisIdAsync();
                if (patientsDiagnosis == null || patientDiagnosisId == null)
                {
                    return BadRequest("patientsDiagnosis or patientDiagnosisId cannot be null");
                }

                return Ok("Patient Founded By DiagnosisId Successfuly");
            }

            return BadRequest("Cannot founded patient Diagnosis By Id");
        }
        
        [HttpGet("GetPatientHistorybyId")]
        public  Task<IActionResult> GetPatientHistorybyId(int patientHistoryId);{
            if (ModelState.IsValid)
            {
                
            }
        }
        //Task<PatientDiagnosis> AddDiagnosisToPatient(int patientDiagnosisId ,int patientId);
    }
}
