using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities;
[Table("DocumentInformation")]
public class DocumentInformationEntity : BaseEntity
{
    public string No { get; set; }
    public string Owner { get; set; }
    public string Version { get; set; }
    public string RevisionDate { get; set; }
    public string ManagedBy { get; set; }
    public string Reference { get; set; }
    public string VersionNotice { get; set; }
    public bool IsActive { get; set; }
}
