using HealthManagement.Infrastructure.Entities;

namespace HealthManagement.Infrastructure.Repositories;

public interface IDoctorRepository
{
    Task<IEnumerable<Doctor>> GetAllAsync();
    Task<Doctor> GetByIdAsync(int id);
}

public class DoctorRepository : IDoctorRepository
{
    public Task<IEnumerable<Doctor>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Doctor> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}