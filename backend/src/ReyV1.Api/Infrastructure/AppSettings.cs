using System.Configuration;

namespace ReyV1.Api.Infrastructure
{
    public class AppSettings
    {
        public string HostUrl { get; set; } = "http://localhost:5000";
        public string ConnectionString { get; set; } = string.Empty;
    }

    public static class AppSettingsProvider
    {
        public static AppSettings Load()
        {
            return new AppSettings
            {
                HostUrl = ConfigurationManager.AppSettings["Nancy:HostUrl"] ?? "http://localhost:5000",
                ConnectionString = ConfigurationManager.AppSettings["Database:ConnectionString"] ?? string.Empty
            };
        }
    }
}
