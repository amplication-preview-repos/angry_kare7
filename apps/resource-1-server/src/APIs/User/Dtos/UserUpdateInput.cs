namespace Resource_1.APIs.Dtos;

public class UserUpdateInput
{
    public DateTime? CreatedAt { get; set; }

    public string? Email { get; set; }

    public bool? EmailVerified { get; set; }

    public string? FullName { get; set; }

    public string? Id { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
