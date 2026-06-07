using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities;

[Table("BatchQuantity")]
public class BatchQuantityEntity : BaseEntity
{
    public Guid BatchId { get; set; }
    public BatchEntity Batch { get; set; }
    public string ProcessName { get; set; }
    public string BoxId { get; set; }
    public int Quantity { get; set; }
    public int NumberOfPrints { get; set; }
    public DateTime LastPrintedUtcDate { get; set; }= DateTime.UtcNow;
}
