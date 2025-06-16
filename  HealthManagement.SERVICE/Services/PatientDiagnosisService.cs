using HealthManagement.Infrastructure.Entities;
using HealthManagement.Infrastructure.Repositories;
using HealthManagement.SERVICE.Interfaces;

namespace HealthManagement.SERVICE.Services;

public class PatientDiagnosisService : IPatientDiagnosisService
{
    private readonly PatientDiagnosisRepository _patientDiagnosisRepository;

    public PatientDiagnosisService(PatientDiagnosisRepository patientDiagnosisRepository)
    {
        _patientDiagnosisRepository = patientDiagnosisRepository;
    }
    public async Task<IEnumerable<PatientDiagnosis>> GetAllPatientsDiagnosis()
    {
        var patient = await _patientDiagnosisRepository.GetAllPatientsDiagnosis();
        if (patient==null||!patient.Any())
        {
            throw new NullReferenceException("patient cannot be null");
        }

        return patient;
    }

    public async Task<PatientDiagnosis> GetPatientByDiagnosisIdAsync(int patientDiagnosisId)
    {
        var patient = await _patientDiagnosisRepository.GetPatientByDiagnosisIdAsync(patientDiagnosisId);
        if (patient==null || patientDiagnosisId==null || patientDiagnosisId < 0)
        {
            throw new NullReferenceException("patient cannot be null");
        }

        return patient;
    }

    public async Task<PatientHistory> GetPatientHistorybyId(int patientHistoryId)
    {
        var patient = await _patientDiagnosisRepository.Gett
    }

    public Task<PatientDiagnosis> AddDiagnosisToPatient(int patientDiagnosisId, int patientId)
    {
        throw new NotImplementedException();
    }
}