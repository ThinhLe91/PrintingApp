namespace DISCPrinting.Application.Dtos.BatchDtos;

public class BatchOutputDto
{
    public Guid Id { get; set; }
    public int RowIndex { get; set; }
    public DateTime CreatedUtcDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedUtcDate { get; set; }
    public string UpdatedBy { get; set; } = string.Empty;

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
}
