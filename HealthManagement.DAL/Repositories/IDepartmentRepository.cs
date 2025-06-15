using HealthManagement.Infrastructure.Entities;
using HealthManagement.Infrastructure.Infrastructures;
using Microsoft.EntityFrameworkCore;

namespace HealthManagement.Infrastructure.Repositories;

public interface IDepartmentRepository
{
    Task<IEnumerable<Departament>> GetAllAsync();
    Task<Departament> GetDepartamentByIdAsync(int departamentId);

}
public class DepartmentRepository : BaseRepository<Departament>, IDepartmentRepository
{
    private readonly HealthManagmentDBContext _context;

    public DepartmentRepository(HealthManagmentDBContext context):base(context) //Error : Constructor 'Object' has 0 parameter(s) but is invoked with 1 argument(s)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Departament>> GetAllAsync()
    {
        if (_context==null||_context.Departaments==null)
        {
            throw new ArgumentException("Departaments cannot be null");
        }

        return await _context.Departaments
            .Include(d=>d.Doctors)
            .ToListAsync();
    }

    public async Task<Departament> GetDepartamentByIdAsync(int departamentId)
    {
        if (_context==null||departamentId==null||_context.Departaments==null)
        {
            throw new ArgumentException("Argument cannot be null");
        }

        return await _context.Departaments
            .FirstOrDefaultAsync(d => d.DepartamentId == departamentId);
    }
}