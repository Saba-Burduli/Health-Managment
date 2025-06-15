using HealthManagement.Infrastructure.Entities;
using HealthManagement.Infrastructure.Infrastructures;
using Microsoft.EntityFrameworkCore;

namespace HealthManagement.Infrastructure.Repositories;

public interface IDoctorRepository
{
    Task<IEnumerable<Doctor>> GetAllAsync();
    Task<Doctor> GetDoctorByIdAsync(int doctorId);
}

public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
{
    private readonly HealthManagmentDBContext _context;
    public DoctorRepository(HealthManagmentDBContext context) : base(context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Doctor>> GetAllAsync()
    {
        if (_context == null || _context.Doctors==null)
        {
            throw new ArgumentException("Argument cannot be null");
        }
        return await _context.Doctors
            .ToListAsync();
    }

    public async Task<Doctor> GetDoctorByIdAsync(int doctorId)
    {
        if (_context==null||_context.Doctors==null)
        {
            throw new ArgumentException("Argument cannot be null");
        }

        return await _context.Doctors
            .Where(d => d.DoctorId == doctorId)
            .FirstOrDefaultAsync();

    }
}