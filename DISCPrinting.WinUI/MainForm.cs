using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using DISCPrinting.WinUI;
using DISCPrinting.WinUI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormApp
{
    public partial class MainForm : Form
    {
        IServiceProvider _serviceProvider;
        private readonly ITimerService _timerService;
        private readonly ICacheService _cacheService;
        private readonly HeaderUC _headerUC;
        public MainForm(IServiceProvider serviceProvider, ITimerService timerService, ICacheService cacheService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _timerService = timerService;
            _timerService.OnOneMinuteTick += OnOneMinuteTick;
            _cacheService = cacheService;
            OpenPage<HomeUC>();
            SetVersion();
            CheckSessionTimeout();
            HeaderPanel.Controls.Clear();
            _headerUC = _serviceProvider.GetRequiredService<HeaderUC>();
            _headerUC.Dock = DockStyle.Fill;
            _headerUC.LogoutChange += Header_LogoutChange;
            _headerUC.RequestPageChange += OnPageChangeRequested;
            HeaderPanel.Controls.Add(_headerUC);
        }

        private void Header_LogoutChange()
        {
            CheckSessionTimeout();
        }

        private void OnOneMinuteTick()
        {
            CheckSessionTimeout();
        }
        private void CheckSessionTimeout()
        {
            if (!_cacheService.Exist(CacheKey.LoginUser))
            {
                this.Hide();
                var loginForm = _serviceProvider.GetRequiredService<LoginForm>();
                if (!loginForm.Visible)
                {
                    var res = loginForm.ShowDialog();
                    if (res != DialogResult.OK)
                    {
                        Application.Exit();
                        Environment.Exit(0);
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }
        }
        private void OpenPage<T>() where T : BaseUserControl
        {
            var uc = _serviceProvider.GetRequiredService<T>();
            ShowControl(uc);
        }
        private void OnPageChangeRequested(Type pageType)
        {
            var nextControl = _serviceProvider.GetRequiredService(pageType) as UserControl;

            if (nextControl != null)
            {
                ShowControl(nextControl);
            }
        }
        public void ShowControl(UserControl control)
        {
            if (MainPanel.Controls.Count > 0)
            {
                var oldControl = MainPanel.Controls[0] as BaseUserControl;
                if (oldControl != null)
                {
                    oldControl.RequestPageChange -= OnPageChangeRequested;
                }
                MainPanel.Controls.Clear();
                oldControl?.Dispose();
            }
            control.Dock = DockStyle.Fill;
            if (control is BaseUserControl baseControl)
            {
                baseControl.RequestPageChange += OnPageChangeRequested;
                if (_headerUC != null)
                    _headerUC.SetTitle(((BaseUserControl)control).PageTitle);
            }
            MainPanel.Controls.Add(control);
            NormalTheme.Apply(MainPanel.Controls);
        }


        private void SetVersion()
        {
            var clickOnceVersion = Environment.GetEnvironmentVariable("ClickOnce_CurrentVersion");

            if (!string.IsNullOrEmpty(clickOnceVersion))
                lblVersion.Text = $"Version: {clickOnceVersion}";
            else
                lblVersion.Text = $"Version {Application.ProductVersion}";
        }

    }
}
