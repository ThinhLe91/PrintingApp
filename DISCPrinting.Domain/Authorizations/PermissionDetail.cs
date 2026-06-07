namespace DISCPrinting.Domain.Authorizations;

public sealed class PermissionDetail : Attribute
{
    public PermissionDetail() { }
    public string ModuleName { get; set; }
    public string GroupName { get; set; }
    public string Description { get; set; }

    public string Action { get; set; }

    public string Name { get; set; }
    public short Value { get; set; }
}
