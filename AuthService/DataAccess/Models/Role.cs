using Microsoft.AspNetCore.Identity;

namespace AuthService.DataAccess.Models;

public class Role : IdentityRole<Guid>
{
    public Role(string roleName) : base(roleName)
    {
    }

    public Role() : base()
    {
    }
}