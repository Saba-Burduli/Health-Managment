using HealthManagement.Infrastructure.Entities;
using HealthManagement.Infrastructure.Repositories;
using HealthManagement.SERVICE.Interfaces;

namespace HealthManagement.SERVICE.Services;

public class DoctorService : IDoctorService
{
    private readonly DoctorRepository _diDoctorRepository;
    public DoctorService(DoctorRepository diDoctorRepository)
    {
        _diDoctorRepository = diDoctorRepository;
    }
    public async Task<IEnumerable<Doctor>> GetALlDoctorsAsync()
    {
        var doctor = await _diDoctorRepository.GetAllDoctorsAsync();
        if (doctor==null || !doctor.Any())
        {
            throw new NullReferenceException("patients cannot be null");
        }
        
        var doctorModel = doctor.Select(d => new Doctor()
        {
            DoctorId = d.DoctorId,
            FirstName = d.FirstName,
            LastName = d.LastName,
            DateOfBirth = d.DateOfBirth,
            Phone = d.Phone,
            Email = d.Email
        });
        return await Task.FromResult(doctorModel);
    }

    public async Task<Doctor> GetDoctorByIdAsync(int doctorId)
    {
        var doctor = await _diDoctorRepository.GetDoctorByIdAsync(doctorId);
        if (doctorId==null)
        {
            throw new NullReferenceException("Argument is null");
        }
        
        var doctorModel =new Doctor
        {
            DoctorId = doctor.DoctorId,
            FirstName = doctor.FirstName,
            LastName = doctor.LastName,
            DateOfBirth = doctor.DateOfBirth,
            Phone = doctor.Phone,
            Email = doctor.Email
        };
        return await Task.FromResult(doctor);
    }
}