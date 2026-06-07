using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities;

[Table("Role")]
public class RoleEntity : BaseEntity
{
    public string RoleName { get; set; }
}
