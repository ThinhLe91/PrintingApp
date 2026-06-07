namespace DISCPrinting.Domain.Authorizations;

public class DPAPermission : SharedPermission
{
    public new const string Module = "DPA";//Disc Printing Application

    [PermissionDetail(GroupName = "FineBlankingAndDeburring", Action = "Print", Description = "Print fine blanking and deburring documents")]
    public const short FineBlankingAndDeburringPrint = 21;

    [PermissionDetail(GroupName = "FineBlankingAndDeburring", Action = "RePrint", Description = "Re-print fine blanking and deburring documents")]
    public const short FineBlankingAndDeburringRePrint = 22;

    [PermissionDetail(GroupName = "PreparationForCoating", Action = "Print", Description = "Print preparation for coating documents")]
    public const short PreparationForCoatingPrint = 31;

    [PermissionDetail(GroupName = "AOI", Action = "Print", Description = "Print AOI documents")]
    public const short AOIPrint = 41;
}
