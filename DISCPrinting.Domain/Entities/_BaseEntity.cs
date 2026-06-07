using System.ComponentModel.DataAnnotations;

namespace DISCPrinting.Domain.Entities;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public int RowIndex { get; set; }
    public DateTime CreatedUtcDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedUtcDate { get; set; }
    public string UpdatedBy { get; set; } = string.Empty;
    public bool IsDeleted { get; set; } = false;
}
