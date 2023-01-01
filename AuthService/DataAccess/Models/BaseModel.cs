namespace AuthService.DataAccess.Models;

public abstract class BaseModel
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}