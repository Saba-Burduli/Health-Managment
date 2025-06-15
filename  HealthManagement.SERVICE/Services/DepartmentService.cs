using HealthManagement.Infrastructure.Entities;
using HealthManagement.SERVICE.Interfaces;

namespace HealthManagement.SERVICE.Services;

public class DepartmentService : IDepartmentService
{
    public Task<IEnumerable<Departament>> GetAllDepartmentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Departament> GetDepartmentByIdAsync(int departamentId)
    {
        throw new NotImplementedException();
    }
}