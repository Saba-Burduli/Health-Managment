namespace HealthManagement.Infrastructure.Entities;

public class Patient
{
    public int PatientId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; } 
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    
    //Relations:
    
    public int PatientDiagnosisId { get; set; }
    public virtual ICollection<PatientDiagnosis>? PatientDiagnoses { get; set; }
    
    public int EmergencyContactId { get; set; }
    public virtual EmergencyContact? EmergencyContact { get; set; }

    public ICollection<PatientHealthInsurance>? PatientHealthInsurance { get; set; }
    
    public List<PatientHistory>? PatientHistory { get; set; }
    
}