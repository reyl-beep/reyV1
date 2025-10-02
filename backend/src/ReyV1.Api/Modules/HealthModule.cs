using System;
using Nancy;
using ReyV1.Api.Infrastructure;

namespace ReyV1.Api.Modules
{
    public class HealthModule : NancyModule
    {
        public HealthModule(AppSettings appSettings)
        {
            Get("/health", _ => Response.AsJson(new
            {
                status = "OK",
                timestamp = DateTimeOffset.UtcNow,
                environment = "Development",
                version = typeof(HealthModule).Assembly.GetName().Version?.ToString(),
                appSettings.HostUrl,
                databaseConfigured = !string.IsNullOrWhiteSpace(appSettings.ConnectionString)
            }));
        }
    }
}
