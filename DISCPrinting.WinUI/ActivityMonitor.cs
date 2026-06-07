using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using DISCPrinting.WinUI;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.Infrastructure.Winform.Services;

public class ActivityMonitor(IServiceProvider _serviceProvider, ICacheService _cacheService) : IMessageFilter
{
    const int WM_MOUSEMOVE = 0x0200;
    const int WM_LBUTTONDOWN = 0x0201;
    const int WM_RBUTTONDOWN = 0x0204;
    const int WM_KEYDOWN = 0x0100;
    private DateTime _lastUpdate = DateTime.Now;
    public bool PreFilterMessage(ref Message m)
    {
        if (m.Msg == WM_MOUSEMOVE || m.Msg == WM_LBUTTONDOWN ||
                m.Msg == WM_RBUTTONDOWN || m.Msg == WM_KEYDOWN)
        {
            if ((DateTime.Now - _lastUpdate).TotalMinutes > 1)
            {
                if (!_cacheService.Exist(CacheKey.LoginUser))
                {
                    Control targetControl = Control.FromHandle(m.HWnd);
                    Form targetForm = targetControl?.FindForm();

                    if (targetForm is LoginForm)
                    {
                        return false;
                    }
                    else if (targetForm != null)
                    {
                        targetForm?.Hide();
                        var loginForm = _serviceProvider.GetRequiredService<LoginForm>();
                        var res = loginForm.ShowDialog();
                        if (res != DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                _lastUpdate = DateTime.Now;
            }
        }
        return false;
    }

}
