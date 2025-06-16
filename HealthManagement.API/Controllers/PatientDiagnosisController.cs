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
                var patientsDiagnosis = _patientDiagnosisService.GetPatientByDiagnosisIdAsync(patientDiagnosisId);
                
                if (patientsDiagnosis == null || patientDiagnosisId == null)
                {
                    return BadRequest("patientsDiagnosis or patientDiagnosisId cannot be null");
                }

                return Ok("Patient Founded By DiagnosisId Successfuly");
            }

            return BadRequest("Cannot founded patient Diagnosis By Id");
        }

        [HttpGet("GetPatientHistorybyId")]
        public async Task<IActionResult> GetPatientHistorybyId(int patientHistoryId)
        {
            if (ModelState.IsValid)
            {
                var patient = await _patientDiagnosisService.GetPatientHistorybyId(patientHistoryId);
                
                if (patient==null||patientHistoryId==null)
                {
                    return BadRequest("Patient or PatientHistoryId cannot be null");
                }

                return Ok("Patient history founded by Id Successfuly");
            }
            
            return BadRequest("Patient history Not founded by Id");
        }

        [HttpPost("AddDiagnosisToPatient")]
        public async Task<IActionResult> AddDiagnosisToPatient(int patientDiagnosisId, int patientId)
        {
            if (ModelState.IsValid)
            {
                var patient = await _patientDiagnosisService.AddDiagnosisToPatient(patientDiagnosisId, patientId);
                
                if (patient==null || patientDiagnosisId==null || patientId==null)
                {
                    return BadRequest("patient or patientDiagnosisId or patientId cannot be null");
                }
                
                return Ok();
            }
            
            return BadRequest("Cannot add Diagnosis to Patient");
        }
    }
}
