using HealthManagement.Infrastructure.Entities;
using HealthManagement.Infrastructure.Repositories;
using HealthManagement.SERVICE.Interfaces;

namespace HealthManagement.SERVICE.Services;

public class DepartmentService : IDepartmentService
{
    private readonly DepartmentRepository _departmentRepository;
    
    public DepartmentService(DepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }
    
    public async Task<IEnumerable<Departament>> GetAllDepartmentsAsync()
    {
        var departament = await _departmentRepository.GetAllDepartmentsAsync();

        if (departament == null || !departament.Any())
        {
            throw new ArgumentException("Argument cannot be null");
        }
        
        var departamentModel = departament.Select(d => new Departament()
        {
            DepartamentId = d.DepartamentId,
            Phone = d.Phone,
            Email = d.Email
        });
        return await Task.FromResult(departamentModel);
    }

    public Task<Departament> GetDepartmentByIdAsync(int departamentId)
    {
        throw new NotImplementedException();
    }
}