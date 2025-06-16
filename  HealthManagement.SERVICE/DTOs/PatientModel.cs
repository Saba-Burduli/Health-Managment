namespace HealthManagement.SERVICE.DTOs;

public class PatientModel
{
    public int PatiendId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; } 
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
}