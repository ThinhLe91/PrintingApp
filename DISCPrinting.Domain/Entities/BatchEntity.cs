using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities;

[Table("Batch")]
public class BatchEntity : BaseEntity
{
    public string BatchId { get; set; }
    public string Machine { get; set; }
    public string ToolId { get; set; }
    public string CoilCharge { get; set; }
    public string ArticleNumberCoil { get; set; }
    public string ArticleNumberFB { get; set; }
    public string ArticleNumberDB { get; set; }
    public string ProductionVersion { get; set; }
    public string DocumentVersion { get; set; }
    public int RunOrder { get; set; }
    protected virtual List<BatchQuantityEntity> BatchQuantityEntities { get; set; }
}


