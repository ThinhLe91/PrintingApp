using DISCPrinting.Domain.ValueObjects;
using System.Text;

namespace DISCPrinting.Infrastructure.Persistence.Contexts;

internal class SeedData
{
    public static string Add_Setting_DocumentInfo()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"""
            INSERT INTO [Setting]([Id],[SettingKey],[SettingValue],[SettingDescription],[ClientId],[User],[Priority],[CreatedUtcDate],[UpdatedBy],[IsDelete]) VALUES
            (NEWID(),'{SettingKeys.Global.ArticleNumberFB}','0320800410','',NULL,NULL,1,GETUTCDATE(),'',0),
            (NEWID(),'{SettingKeys.Global.NexeedAddress}','10.184.205.12:55065','',NULL,NULL,1,GETUTCDATE(),'',0)
            ;

            INSERT INTO [DocumentInformation]([Id],[No],[Owner],[Version],[RevisionDate],[ManagedBy],[Reference],[IsActive],[CreatedUtcDate],[UpdatedBy],[IsDelete]) VALUES
            (NEWID(),'HcP-001385-002','HcP/MFE1.11 Production Engineer','005','21-05-2026','HcP/MFE1.11','Nguyen Van A',1,GETUTCDATE(),'',0)
            """);
        return sb.ToString();
    }
    public static string Seed_InitRoleAndSetting()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("""
            INSERT INTO [Role]([Id],[RoleName],[CreatedDate],[UpdatedBy],[IsDelete]) VALUES
            (NEWID(),'DISCPrinting.DPA.ADMIN',GETDATE(),'',0),
            (NEWID(),'DISCPrinting.DPA.FAD',GETDATE(),'',0),
            (NEWID(),'DISCPrinting.DPA.PFC',GETDATE(),'',0),
            (NEWID(),'DISCPrinting.DPA.AOI',GETDATE(),'',0)
                ;
            """);

        sb.AppendLine($"""
            INSERT INTO [Setting]([Id],[SettingKey],[SettingValue],[SettingDescription],[ClientId],[User],[Priority],[CreatedDate],[UpdatedBy],[IsDelete]) VALUES
            (NEWID(),'{SettingKeys.Global.Author}','HcP/ICO3','',NULL,NULL,1,GETDATE(),'',0),
            (NEWID(),'{SettingKeys.Global.SessionExpireMinutes}','15','Login session duration is measured in minutes. Users will be automatically logged out after a period of inactivity.',NULL,NULL,1,GETDATE(),'',0),
            (NEWID(),'{SettingKeys.Client.TemplatePath}','','This folder contains the print templates. If left blank, the application defaults to the installation directory. Note: Network shared folders are not supported.',NULL,NULL,2,GETDATE(),'',0)
            ;
            """);
        return sb.ToString();
    }

    public static string Seed_Add_DeburringTime_setting()
    {
        var sb = new StringBuilder();
        sb.AppendLine("""
            UPDATE [DocumentInformation] SET [VersionNotice]='The valid version is published on Bosch Document System';
            """);
        sb.AppendLine($"""
            INSERT INTO [Setting]([Id],[SettingKey],[SettingValue],[SettingDescription],[ClientId],[User],[Priority],[CreatedUtcDate],[UpdatedBy],[IsDeleted]) VALUES
            (NEWID(),'{SettingKeys.Global.DeburringTime}','DISC   15min','Default text: DISC   15min (There are 3 spaces between DISC and 15min Huynh Phuoc Hoa (HcP/MFE1.12) confirmed)',NULL,NULL,1,GETDATE(),'',0),
            (NEWID(),'{SettingKeys.Global.ArticleNumberDB}','0320800410','',NULL,NULL,1,GETDATE(),'',0),
            (NEWID(),'{SettingKeys.Client.DefaultPaperPrinter}','','',NULL,NULL,2,GETDATE(),'',0),
            (NEWID(),'{SettingKeys.Client.DefaultLabelPrinter}','','',NULL,NULL,2,GETDATE(),'',0),
            (NEWID(),'{SettingKeys.Global.ProductVersion}','001','',NULL,NULL,2,GETDATE(),'',0)
            ;
            """);
        return sb.ToString();
    }

    public static string Seed_INIT_Printemplate()
    {
        return $"""
            INSERT INTO [PrintTemplate]([PaperType],[Process],[Width],[Height],[IsLandscape],[IsLabel],[FileName],[Order],[NumberOfPrint],[Id],[CreatedUtcDate],[UpdatedBy],[IsDeleted]) VALUES
            ('{PaperType.MainGuidanceSheet}','{Processes.DISC_FB}',8.27,11.69,0,0,'01-FB-MainGuidanceSheet.html',1,1,NEWID(),GETDATE(),'',0),
            ('{PaperType.SubGuidanceSheet}','{Processes.DISC_FB}',8.27,11.69,1,0,'02-FB-SubGuidanceSheet.html',2,8,NEWID(),GETDATE(),'',0),
            ('{PaperType.BookingForm}','{Processes.DISC_FB}',8.27,11.69,1,0,'03-FB-BookingForm.html',3,6,NEWID(),GETDATE(),'',0),
            ('{PaperType.MeasuringSheet}','{Processes.DISC_FB}',8.27,11.69,0,0,'04-FB-MeasuringSheet.html',4,1,NEWID(),GETDATE(),'',0),
            ('{PaperType.MeasuringLabel}','{Processes.DISC_FB}',3.6,3,0,1,'05-FB-MeasuringLabel.html',5,1,NEWID(),GETDATE(),'',0),
            ('{PaperType.StorageLabel}','{Processes.DISC_FB}',3.6,3,0,1,'06-FB-StorageLabel.html',6,1,NEWID(),GETDATE(),'',0),
            ('{PaperType.BookingForm}','{Processes.DISC_DB}',8.27,11.69,1,0,'11-DB-BookingForm.html',11,1,NEWID(),GETDATE(),'',0),
            ('{PaperType.BarcodeLabel}','{Processes.DISC_FB}',3.6,3,0,1,'12-DB-SampleLabel.html',12,1,NEWID(),GETDATE(),'',0),
            ('{PaperType.BarcodeSheet}','{Processes.DISC_PFC}',8.27,11.69,0,0,'21-PFC-PreparationForCoating.html',21,1,NEWID(),GETDATE(),'',0),
            ('{PaperType.BarcodeLabel}','{Processes.DISC_PFC}',3.6,3,0,1,'22-PFC-SampleLabel.html',22,8,NEWID(),GETDATE(),'',0),
            ('{PaperType.BarcodeLabel}','{Processes.DISC_AOI}',3.6,3,0,1,'31-AOI-Label.html',31,2,NEWID(),GETDATE(),'',0)
            """;
    }
}
