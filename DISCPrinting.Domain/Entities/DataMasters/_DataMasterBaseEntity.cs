using System.ComponentModel.DataAnnotations;

namespace DISCPrinting.Domain.Entities.DataMasters;

public abstract class DataMasterBaseEntity<TKey>
{

    public bool IsDeleted { get; set; }
    public DateTime? CreatedDate { get; set; }
    [MaxLength(20)]
    public string? CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    [MaxLength(20)]
    public string? ModifiedBy { get; set; }
}
