using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI.Forms;

public partial class BaseUserControl : UserControl
{
    protected IServiceScopeFactory ScopeFactory { get; set; } = null!;
    public event Action<Type> RequestPageChange;
    public virtual string PageTitle { get => throw new NotImplementedException("You must implement the PageTitle property in the subclass."); }
    protected BaseUserControl()
    {
        InitializeComponent();
    }

    protected BaseUserControl(IServiceScopeFactory scopeFactory) : this()
    {
        ScopeFactory = scopeFactory;
    }

    public virtual void Initialize(IServiceScopeFactory scopeFactory)
    {
        this.ScopeFactory = scopeFactory;
    }

    protected void NavigateTo<T>() where T : BaseUserControl
    {
        RequestPageChange?.Invoke(typeof(T));
    }

    protected void HandleError(Exception ex)
    {
        MessageBox.Show(ex.Message);
    }

    protected async Task<TResult> ExecuteServiceAsync<TService, TResult>(Func<TService, Task<TResult>> action, object? serviceKey = null)
        where TService : class
    {
        if (this.DesignMode) return default;
        try
        {
            if (ScopeFactory == null)
                throw new InvalidOperationException("ScopeFactory has not been initialized. Use DI to create the UserControl.");
            using var scope = ScopeFactory.CreateScope();
            var service = serviceKey == null ? scope.ServiceProvider.GetRequiredService<TService>()
                : scope.ServiceProvider.GetRequiredKeyedService<TService>(serviceKey);
            return await action(service);
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
        return default;
    }

    protected async Task ExecuteServiceAsync<TService>(Func<TService, Task> action, object? serviceKey = null)
        where TService : class
    {
        if (this.DesignMode) return;
        try
        {
            if (ScopeFactory == null)
                throw new InvalidOperationException("ScopeFactory has not been initialized. Use DI to create the UserControl.");
            using var scope = ScopeFactory.CreateScope();
            var service = serviceKey == null ? scope.ServiceProvider.GetRequiredService<TService>()
                : scope.ServiceProvider.GetRequiredKeyedService<TService>(serviceKey);
            await action(service);
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
        return;
    }

    protected TResult ExecuteService<TService, TResult>(Func<TService, TResult> action, object? serviceKey = null)
        where TService : class
    {
        if (this.DesignMode) return default;
        try
        {
            if (ScopeFactory == null)
                throw new InvalidOperationException("ScopeFactory has not been initialized. Use DI to create the UserControl.");
            using var scope = ScopeFactory.CreateScope();
            var service = serviceKey == null ? scope.ServiceProvider.GetRequiredService<TService>()
                : scope.ServiceProvider.GetRequiredKeyedService<TService>(serviceKey);
            return action(service);
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
        return default;
    }

    protected void ExecuteService<TService>(Action<TService> action, object? serviceKey = null)
        where TService : class
    {
        if (this.DesignMode) return;
        try
        {
            if (ScopeFactory == null)
                throw new InvalidOperationException("ScopeFactory has not been initialized. Use DI to create the UserControl.");
            using var scope = ScopeFactory.CreateScope();
            var service = serviceKey == null ? scope.ServiceProvider.GetRequiredService<TService>()
                : scope.ServiceProvider.GetRequiredKeyedService<TService>(serviceKey);
            action(service);
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
        return;
    }

    protected void SetBusyState(bool isBusy)
    {
        if (this.InvokeRequired)
        {
            this.Invoke(new MethodInvoker(() => SetBusyState(isBusy)));
            return;
        }

        this.Cursor = isBusy ? Cursors.WaitCursor : Cursors.Default;
        this.Enabled = !isBusy;
    }
}
