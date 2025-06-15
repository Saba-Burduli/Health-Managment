using HealthManagement.Infrastructure.Entities;
using HealthManagement.SERVICE.Interfaces;

namespace HealthManagement.SERVICE.Services;

public class PatientService : IPatientService
{
    public Task<IEnumerable<Patient>> GetALlPatientsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Patient> GetPatientById(int patientId)
    {
        throw new NotImplementedException();
    }

    public Task<Patient> AddPatientAsync(Patient patient)
    {
        throw new NotImplementedException();
    }

    public Task<Patient> UpdatePatientAsync(Patient patient)
    {
        throw new NotImplementedException();
    }
}