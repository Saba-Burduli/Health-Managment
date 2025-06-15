using HealthManagement.Infrastructure.Entities;

namespace HealthManagement.SERVICE.Interfaces;

public interface IPatientDiagnosisService
{
    //	Handles : Diagnoses, history
    Task<IEnumerable<PatientDiagnosis>> GetAllPatientsDiagnosis();
    Task<PatientDiagnosis> GetPatientByDiagnosisIdAsync(int patientDiagnosisId);
    Task<PatientHistory> GetPatientHistorybyId(int patientHistoryId);

    Task<PatientDiagnosis> AddDiagnosisToPatient(int patientDiagnosisId ,int patientId);

}