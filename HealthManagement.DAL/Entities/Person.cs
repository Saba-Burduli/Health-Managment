using System.ComponentModel.DataAnnotations;

namespace HealthManagement.Infrastructure.Entities;

public class Person
{
    [Key]
    public int PersonId { get; set; }
        
    [Required]
    [MaxLength(20, ErrorMessage = "FistName is more than 20 letter")]
    public string? FirstName { get; set; }

    [Required]
    [MaxLength(30, ErrorMessage = "LastName is more than 30 letter")]
    public string? LastName { get; set; }

    [Required]
    [MaxLength(20, ErrorMessage = "Phone number is more than 20 letter")]
    public string? Phone { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "address is more than 50 letter")]
    public string? Address { get; set; }

    //Relations:
    public virtual User? User { get; set; }
}