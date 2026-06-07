using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities;

[Table("Setting")]
public class SettingEntity : BaseEntity
{
    public string SettingKey { get; set; }
    public string SettingValue { get; set; }
    public string? SettingDescription { get; set; }
    public string? ClientId { get; set; }
    public string? User { get; set; }
    public int Priority { get; set; }
}
