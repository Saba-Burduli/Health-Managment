using HealthManagement.Infrastructure.Entities;
using HealthManagement.Infrastructure.Infrastructures;
using Microsoft.EntityFrameworkCore;

namespace HealthManagement.Infrastructure.Repositories;

public interface IPatientDiagnosisRepository
{
    Task<IEnumerable<PatientDiagnosis>> GetPatientByIdAsync(int patientDiagnosisId);
    Task AddPatientDiagnosisAsync(PatientDiagnosis diagnosis);
}

public class PatientDiagnosisRepository : BaseRepository<PatientDiagnosis>, IPatientDiagnosisRepository
{
    private readonly HealthManagmentDBContext _context;

    public PatientDiagnosisRepository(HealthManagmentDBContext context):base(context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<PatientDiagnosis>> GetPatientByIdAsync(int patientDiagnosisId)
    {
        if (_context==null||_context.PatientDiagnoses==null)
        {
            throw new ArgumentException("Arguments cannot be null");
        }

        return await _context.PatientDiagnoses
            .Where(p => p.PatientDiagnosisId == patientDiagnosisId)
            .ToListAsync();
    }

    //I can add (Task<PatientDiagnosis>)and use return
    public async Task AddPatientDiagnosisAsync(PatientDiagnosis diagnosis)
    {
        if (_context==null || _context.PatientDiagnoses==null)
        {
            throw new ArgumentException("Arguments cannot be null");
        }
        await _context.PatientDiagnoses.AddAsync(diagnosis);
        await _context.SaveChangesAsync();
    }
}