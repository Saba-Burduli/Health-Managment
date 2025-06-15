using HealthManagement.Infrastructure.Entities;
using HealthManagement.SERVICE.Interfaces;

namespace HealthManagement.SERVICE.Services;

public class PatientDiagnosisService : IPatientDiagnosisService
{
    public Task<IEnumerable<PatientDiagnosis>> GetAllPatientsDiagnosis()
    {
        throw new NotImplementedException();
    }

    public Task<PatientDiagnosis> GetPatientByDiagnosisIdAsync(int patientDiagnosisId)
    {
        throw new NotImplementedException();
    }

    public Task<PatientHistory> GetPatientHistorybyId(int patientHistoryId)
    {
        throw new NotImplementedException();
    }

    public Task<PatientDiagnosis> AddDiagnosisToPatient(int patientDiagnosisId, int patientId)
    {
        throw new NotImplementedException();
    }
}