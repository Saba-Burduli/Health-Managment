using System.Reflection.Metadata.Ecma335;

namespace HealthManagement.Infrastructure.Entities;
public class PatientDiagnosis
{
    public int PatientDiagnosisId { get; set; }
    public DateTime? DateOfDiagnosis { get; set; } = DateTime.Now;
    
    //Relations:
    public int PatientId { get; set; }
    public virtual Patient? Patient { get; set; }

    public int DoctorId { get; set; }
    public virtual Doctor? Doctor { get; set; }
    
    public int PatientHistoryId { get; set; }
    public virtual PatientHistory? PatientHistory { get; set; }
    
    public virtual HospitalDiagnosisList? HospitalDiagnosisList { get; set; }
}