using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace HealthManagement.Infrastructure.Entities;
[Table("PatientHealthInsurance")]
public class PatientHealthInsurance
{
    [Key]
    public int HealthInsuranceId { get; set; }
    
    //Relations:
    public int PatiendId { get; set; }
    public virtual Patient? Patient { get; set; }
}