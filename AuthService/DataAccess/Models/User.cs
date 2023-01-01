using Microsoft.AspNetCore.Identity;

namespace AuthService.DataAccess.Models;

public class User : IdentityUser<Guid>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public DateTime Created { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
    // public string Username { get; set; }
}