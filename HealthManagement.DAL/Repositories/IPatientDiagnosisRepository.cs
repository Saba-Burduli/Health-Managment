using HealthManagement.Infrastructure.Entities;

namespace HealthManagement.Infrastructure.Repositories;

public interface IPatientDiagnosisRepository
{
    Task<IEnumerable<PatientDiagnosis>> GetByPatientIdAsync(int patientDiagnosisId);
    Task AddAsync(PatientDiagnosis diagnosis);
}

public class PatientDiagnosisRepository : IPatientDiagnosisRepository
{
    
    public Task<IEnumerable<PatientDiagnosis>> GetByPatientIdAsync(int patientDiagnosisId)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(PatientDiagnosis diagnosis)
    {
        throw new NotImplementedException();
    }
}