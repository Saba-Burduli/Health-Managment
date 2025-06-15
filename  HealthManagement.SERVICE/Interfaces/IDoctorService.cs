using HealthManagement.Infrastructure.Entities;

namespace HealthManagement.SERVICE.Interfaces;

public interface IDoctorService
{
    Task<IEnumerable<Doctor>> GetALlDoctorsAsync();
    Task<Doctor> GetDoctorByIdAsync(int doctorId);
}