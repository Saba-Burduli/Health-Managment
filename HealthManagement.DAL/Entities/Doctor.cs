namespace HealthManagement.Infrastructure.Entities;

public class Doctor
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    
    //Relations :
    public int DepartmentId { get; set; }
    public virtual Departament? Departament { get; set; }
    
    public List<PatientDiagnosis>? PatientDiagnoses { get; set; }
    
    public List<PatientHistory>? PatimeHistories { get; set; }
}