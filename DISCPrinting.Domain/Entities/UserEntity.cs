using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities;

[Table("User")]
public class UserEntity : BaseEntity
{
    public string Username { get; set; }
    public string DisplayName { get; set; }
}
