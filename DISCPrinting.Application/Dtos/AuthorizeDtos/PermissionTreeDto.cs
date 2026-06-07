namespace DISCPrinting.Application.Dtos.AuthorizeDtos;

public class PermissionTreeDto
{
    public string ModuleName { get; set; }
    public string GroupName { get; set; }
    public string Action { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsAllow { get; set; }
}
