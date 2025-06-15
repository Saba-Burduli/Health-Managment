namespace HealthManagement.Infrastructure.Entities;

public class HospitalDiagnosisList
{
    public string? laboratoryName { get; set; }
    public string? laboratoryAddress { get; set; }
    public string? laboratoryPhone { get; set; }
    public string? laboratoryEmail { get; set; }
    
    //Relations:
    
    public int? DepartamentId { get; set; }
    public virtual Departament? Departament { get; set; }
    
    public List<PatientDiagnosis>? PatientDiagnosis { get; set; }
}