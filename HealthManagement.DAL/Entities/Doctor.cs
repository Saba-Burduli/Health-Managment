using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthManagement.Infrastructure.Entities;
[Table("Doctor")]
public class Doctor
{
    [Key]
    public int DoctorId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    
    //Relations :
    
    [ForeignKey("Departament")]
    public int DepartmentId { get; set; }
    public virtual Departament? Departament { get; set; }
    
    public List<PatientDiagnosis>? PatientDiagnoses { get; set; }
    
    public List<PatientHistory>? PatimeHistories { get; set; }
}