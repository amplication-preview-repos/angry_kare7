using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resource_1.Infrastructure.Models;

[Table("Users")]
public class UserDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public string? Email { get; set; }

    public bool? EmailVerified { get; set; }

    [StringLength(1000)]
    public string? FullName { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? PhoneNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
