using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI.Forms;

public partial class ContactUC : BaseUserControl
{
    public ContactUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
    }

    public override string PageTitle => "Contact";

    private async void btnSend_Click(object sender, EventArgs e)
    {
        var res = await ExecuteServiceAsync<IEmailService, bool>(_ => _.SendEmail(new SendEmailDto()
        {
            Subject = txtSubject.Text,
            Content = txtContent.Text
        }));
        MessageBox.Show(res ? "Send email successed" : "Send email failed", "Notification");
    }
}
