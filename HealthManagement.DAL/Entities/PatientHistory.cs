using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace HealthManagement.Infrastructure.Entities;
[Table("PatientHistory")]
public class PatientHistory
{
    [Required]
    public DateTime DateOfVisit { get; set; } = DateTime.Now;
    
    //Relations:
    public int DoctorId { get; set; } 
    public virtual Doctor? Doctor { get; set; }

    public int PatientId { get; set; }
    public virtual Patient? Patient { get; set; }
    
    public List<PatientDiagnosis>? PatientDiagnoses { get; set; }
    
}