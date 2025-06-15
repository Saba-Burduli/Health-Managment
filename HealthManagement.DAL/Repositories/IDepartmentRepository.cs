using HealthManagement.Infrastructure.Entities;

namespace HealthManagement.Infrastructure.Repositories;

public interface IDepartmentRepository
{
    Task<IEnumerable<Departament>> GetAllAsync();
    Task<Departament> GetByIdAsync(int departamentId);

}
public class DepartmentRepository : IDepartmentRepository
{
    public Task<IEnumerable<Departament>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Departament> GetByIdAsync(int departamentId)
    {
        throw new NotImplementedException();
    }
}