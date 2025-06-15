namespace HealthManagement.Infrastructure.Entities;

public class HospitalDiagnosisList
{
    public string? LaboratoryName { get; set; }
    public string? LaboratoryAddress { get; set; }
    public string? LaboratoryPhone { get; set; }
    public string? LaboratoryEmail { get; set; }
    
    //Relations:
    
    public int? DepartamentId { get; set; }
    public virtual Departament? Departament { get; set; }
    
    public List<PatientDiagnosis>? PatientDiagnosis { get; set; }
}