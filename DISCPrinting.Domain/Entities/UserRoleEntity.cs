using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities;


[Table("UserRole")]
public class UserRoleEntity : BaseEntity
{
    public string Username { get; set; }
    public string RoleName { get; set; }
}
