using System;
using System.Configuration;
using Microsoft.Owin.Hosting;

namespace ReyV1.Api
{
    internal static class Program
    {
        private static void Main()
        {
            var hostUrl = ConfigurationManager.AppSettings["Nancy:HostUrl"] ?? "http://localhost:5000";
            using (WebApp.Start<Startup>(hostUrl))
            {
                Console.WriteLine($"ReyV1 API escuchando en {hostUrl}");
                Console.WriteLine("Presione ENTER para detener el servidor...");
                Console.ReadLine();
            }
        }
    }
}
