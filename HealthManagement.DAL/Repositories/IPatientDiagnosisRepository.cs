using HealthManagement.Infrastructure.Entities;
using HealthManagement.Infrastructure.Infrastructures;
using Microsoft.EntityFrameworkCore;

namespace HealthManagement.Infrastructure.Repositories;

public interface IPatientDiagnosisRepository
{
    public Task<PatientHistory> GetPatientHistorybyId(int patientHistoryId);
    public Task<PatientDiagnosis> GetPatientByDiagnosisIdAsync(int patientDiagnosisId);
    public Task<IEnumerable<PatientDiagnosis>> GetAllPatientsDiagnosis(); //no needed for now
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
    
    public async Task<PatientHistory> GetPatientHistorybyId(int patientHistoryId)
    {
        if (_context==null||_context.PatientDiagnoses==null||patientHistoryId==null)
        {
            throw new ArgumentNullException();
        }
        return await _context.pati
    }
    
    public async Task<PatientDiagnosis> GetPatientByDiagnosisIdAsync(int patientDiagnosisId)
    {
        if (patientDiagnosisId==null || _context.Users==null || _context.PatientDiagnoses==null)
        {
            throw new ArgumentException("Argument Cannot be null");
        }
        return await _context.PatientDiagnoses
            .FirstOrDefaultAsync(p => p.PatientDiagnosisId == patientDiagnosisId);
    }
    
    public async Task<IEnumerable<PatientDiagnosis>> GetAllPatientsDiagnosis()
    {
        if (_context==null||_context.PatientDiagnoses==null)
        {
            throw new ArgumentException("Arguments cannot be null");
        }
        
        return await _context.PatientDiagnoses
            .ToListAsync();
    }

    public async Task<IEnumerable<PatientDiagnosis>> GetPatientByIdAsync(int patientDiagnosisId)
    {
        if (_context==null || _context.PatientDiagnoses==null)
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