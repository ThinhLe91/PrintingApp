using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities;
[Table("PrintTemplate")]
public class PrintTemplateEntity : BaseEntity
{
    public string PaperType { get; set; }
    public string Process { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public bool IsLandscape { get; set; }
    public bool IsLabel { get; set; }
    public string FileName { get; set; }
    public int Order { get; set; }
    public int NumberOfPrint { get; set; } = 1;
}
