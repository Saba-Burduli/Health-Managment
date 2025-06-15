using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthManagement.Infrastructure.Entities;
[Table("Role")]
public class Role
{
    [Key]
    public int RoleId { get; set; }
    [Required]
    public string? RoleName { get; set; }
    
    //Relations:
    public virtual ICollection<User> Users { get; set; }
}