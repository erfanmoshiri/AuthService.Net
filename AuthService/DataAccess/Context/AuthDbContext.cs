using AuthService.DataAccess.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthService.DataAccess.Context;

public class AuthDbContext : IdentityDbContext<User, Role, Guid>

{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
    }

    // private DbSet<User> Users { get; set; }
}