using HealthManagement.Infrastructure.Entities;
using HealthManagement.SERVICE.Interfaces;

namespace HealthManagement.SERVICE.Services;

public class DoctorService : IDoctorService
{
    public Task<IEnumerable<Doctor>> GetALlDoctorsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Doctor> GetDoctorByIdAsync(int doctorId)
    {
        throw new NotImplementedException();
    }
}