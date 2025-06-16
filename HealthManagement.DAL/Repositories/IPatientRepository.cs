using HealthManagement.Infrastructure.Entities;
using HealthManagement.Infrastructure.Infrastructures;
using Microsoft.EntityFrameworkCore;

namespace HealthManagement.Infrastructure.Repositories;

public interface IPatientRepository
{
    Task<IEnumerable<Patient>> GetAllPatientsAsync();
    Task<Patient> GetPatientByIdAsync(int patientId);
    Task AddPatientAsync(Patient patient);
    Task UpdatePatientAsync(Patient patient);
}

public class PatientRepository : BaseRepository<Patient> , IPatientRepository 
{
    public readonly HealthManagmentDBContext _context;

    public PatientRepository(HealthManagmentDBContext context) : base(context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
    {
        if (_context==null||_context.Patients==null)
        {
            throw new ArgumentException("Argument cannot be null");
        }

        return await _context.Patients
            .ToListAsync();
    }
    public Task<Patient> GetPatientByIdAsync(int patientId)
    {
        if (_context==null||_context.Patients==null)
        {
            throw new ArgumentException("Argument cannot be null");
        }

        return _context.Patients
            .Where(p => p.PatientId == patientId)
            .FirstOrDefaultAsync();
    }

    public async Task AddPatientAsync(Patient patient)
    {
        if (_context==null||_context.Patients==null)
        {
            throw new ArgumentException("Argument cannot be null");
        }

        await _context.Patients.AddAsync(patient);
        await _context.SaveChangesAsync();
    }

    public async Task UpdatePatientAsync(Patient patient)
    {
        if (_context==null||_context.Patients==null)
        {
            throw new ArgumentException("Argument cannot be null");
        }

        _context.Patients.Update(patient);
        await _context.SaveChangesAsync();
    }
}