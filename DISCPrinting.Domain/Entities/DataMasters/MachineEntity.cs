using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DISCPrinting.Domain.Entities.DataMasters;

[Table("Machine", Schema = "Location")]
public class MachineEntity : DataMasterBaseEntity<short>
{
    [Column("MachineID")]
    public short Id { get; set; }

    [MaxLength(50)]
    public string? MachineName { get; set; }
    [MaxLength(100)]
    public string? MachineDescription { get; set; }
    [MaxLength(50)]
    public string? MachineNumber { get; set; }
    [MaxLength(100)]
    public string? Remark { get; set; }
    public short? ProcessID { get; set; }
    public short? NumberOfTrack { get; set; }
    public short? GroupProcessID { get; set; }

}
