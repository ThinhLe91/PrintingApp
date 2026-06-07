namespace DISCPrinting.Domain.Interfaces.Services;

public interface ITimerService
{
    event Action OnOneMinuteTick;
    void Start();
    void Stop();
}
