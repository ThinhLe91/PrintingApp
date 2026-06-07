using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities;

[Table("RoleToPermission")]
public class RoleToPermissionEntity : BaseEntity
{
    [Required(AllowEmptyStrings = false)]
    public string RoleName { get; set; }
    public string Description { get; set; }
    public string PermissionsInRole { get; set; }
}
