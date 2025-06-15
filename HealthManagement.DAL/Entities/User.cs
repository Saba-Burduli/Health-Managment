using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthManagement.Infrastructure.Entities;
[Table("User")]
public class User
{
    [Key]
    public int? UserId { get; set; }
    [Required]
    [MaxLength(20 , ErrorMessage = "UserName lenght is more than 20")]
    public string? UserName { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    
    //Relations :
    public virtual Role? Role { get; set; } //we can also make this many to many (optional)
    public virtual Person? Person { get; set; }
}