namespace DISCPrinting.Application.Dtos.SettingDtos;

public class SettingOutputDto
{
    public Guid Id { get; set; }
    public string SettingKey { get; set; }
    public string SettingValue { get; set; }
    public string SettingDescription { get; set; }
    public string Scope { get; set; }
    public string? ClientId { get; set; }
    public string? User { get; set; }
}
