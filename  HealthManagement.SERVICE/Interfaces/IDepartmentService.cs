using HealthManagement.Infrastructure.Entities;

namespace HealthManagement.SERVICE.Interfaces;

public interface IDepartmentService
{
    Task<IEnumerable<Departament>> GetAllDepartmentsAsync();
    Task<Departament> GetDepartmentByIdAsync(int departamentId);
}