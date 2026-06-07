namespace DISCPrinting.Application.Dtos.DataMasterDtos;

public class MachineOutputDto
{
    public short MachineID { get; set; }
    public string? MachineName { get; set; }
    public string? MachineDescription { get; set; }
    public string? MachineNumber { get; set; }
    public string? Remark { get; set; }
    public short? ProcessID { get; set; }
    public short? NumberOfTrack { get; set; }
    public short? GroupProcessID { get; set; }
}
