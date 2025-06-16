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
        if (patientHistoryId <= 0)
        {
            throw new ArgumentException("Patient history ID must be greater than 0");
        }

        var patient = await _patientDiagnosisRepository.GetPatientHistorybyId(patientHistoryId);
        if (patient == null)
        {
            throw new NullReferenceException("Patient history not found");
        }

        return patient;
    }

    public async Task<PatientDiagnosis> AddDiagnosisToPatient(int patientDiagnosisId, int patientId)
    {
        if (patientDiagnosisId <= 0 || patientId <= 0)
        {
            throw new ArgumentException("IDs must be greater than 0");
        }
    
        var diagnosis = await _patientDiagnosisRepository.GetPatientByDiagnosisIdAsync(patientDiagnosisId);
        if (diagnosis == null)
        {
            throw new NullReferenceException("Diagnosis not found");
        }
    
        diagnosis.PatientId = patientId;
    
        await _patientDiagnosisRepository.AddPatientDiagnosisAsync(diagnosis);
    
        return diagnosis;
    }
}