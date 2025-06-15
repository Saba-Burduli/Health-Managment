namespace HealthManagement.Infrastructure.Entities;

public class HealthInsurance
{
    public string? CompanyName { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    
    //Relations :
    public virtual ICollection<PatientHealthInsurance>? PatientHealthInsurances { get; set; }
    
}
