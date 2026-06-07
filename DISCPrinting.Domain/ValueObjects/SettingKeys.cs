namespace DISCPrinting.Domain.ValueObjects;

public static class SettingKeys
{
    public static class Global
    {
        public const string Author = "Global.Author";
        public const string SessionExpireMinutes = "Global.SessionExpireMinutes";
        public const string ArticleNumberFB = "Global.ArticleNumberFB";
        public const string ArticleNumberDB = "Global.ArticleNumberDB";
        public const string NexeedAddress = "Global.NexeedAddress";
        public const string DeburringTime = "Global.DeburringTime";
        public const string ProductVersion = "Global.ProductVersion";
    }
    public static class Client
    {
        public const string TemplatePath = "Client.TemplatePath";
        public const string DefaultPaperPrinter = "Client.DefaultPaperPrinter";
        public const string DefaultLabelPrinter = "Client.DefaultLabelPrinter";
    }
    public static class User
    {

    }
}
