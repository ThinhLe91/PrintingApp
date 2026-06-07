using DISCPrinting.Domain.Interfaces.Providers;
using System.Management;

namespace DISCPrinting.Infrastructure.Winform.Services;

public class ClientProvider : IClientProvider
{
    public string GetMachineGuid()
    {
        string uuid = string.Empty;
        ManagementClass mc = new ManagementClass("Win32_ComputerSystemProduct");
        ManagementObjectCollection moc = mc.GetInstances();

        foreach (ManagementObject mo in moc)
        {
            uuid = mo.Properties["UUID"].Value.ToString();
            break;
        }
        return uuid;
    }
}
