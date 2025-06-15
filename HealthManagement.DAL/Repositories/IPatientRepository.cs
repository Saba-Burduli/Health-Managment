using HealthManagement.Infrastructure.Entities;

namespace HealthManagement.Infrastructure.Repositories;

public interface IPatientRepository
{
    Task<IEnumerable<Patient>> GetAllAsync();
    Task<Patient> GetByIdAsync(int patientId);
    Task AddAsync(Patient patient);
    Task UpdateAsync(Patient patient);
}

public class PatientRepository : IPatientRepository
{
    public Task<IEnumerable<Patient>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Patient> GetByIdAsync(int patientId)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Patient patient)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Patient patient)
    {
        throw new NotImplementedException();
    }
}