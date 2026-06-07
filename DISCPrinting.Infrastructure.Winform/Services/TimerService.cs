using DISCPrinting.Domain.Interfaces.Services;

namespace DISCPrinting.Infrastructure.Winform.Services;

public class TimerService : ITimerService, IDisposable
{
    private readonly System.Windows.Forms.Timer _timer;
    public event Action OnOneMinuteTick;

    public TimerService()
    {
        _timer = new System.Windows.Forms.Timer();
        _timer.Interval = 60000;
        _timer.Tick += (s, e) => OnOneMinuteTick?.Invoke();
    }

    public void Start() => _timer.Start();
    public void Stop() => _timer.Stop();

    public void Dispose()
    {
        _timer?.Stop();
        _timer?.Dispose();
    }
}
