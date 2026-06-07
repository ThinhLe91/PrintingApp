namespace DISCPrinting.Application.Dtos.AuthorizeDtos;

public class RoleWithPermissionDto
{
    public string RoleName { get; set; }
    public List<PermissionTreeDto> Permissions { get; set; }
    public override string ToString() => RoleName;
}
