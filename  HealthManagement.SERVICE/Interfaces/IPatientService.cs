using HealthManagement.Infrastructure.Entities;

namespace HealthManagement.SERVICE.Interfaces;

public interface IPatientService
{
    Task<IEnumerable<Patient>> GetALlPatientsAsync();
    Task<Patient> GetPatientByIdAsync(int patientId);
    Task<Patient> AddPatientAsync(Patient patient); //we can delate <patient>
    Task<Patient> UpdatePatientAsync(Patient patient); //we can delate <patient>
}