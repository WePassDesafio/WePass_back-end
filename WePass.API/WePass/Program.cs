using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.IO;
using WePass.API.Extension;
using WePass.Domain.Configuration;
using WePass.Infra.Context;


namespace WePass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args)
            .MigrateDbContext<WePassContext>((context, services) =>
            {
                var env = services.GetService<IHostingEnvironment>();
                var settings = services.GetService<IOptions<WePassConfigurations>>();
            }).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureAppConfiguration((builderContext, config) =>
            {
                config.AddEnvironmentVariables();
            }).ConfigureLogging((hostingContext, builder) =>
            {
                builder.AddConfiguration(hostingContext.Configuration.GetSection("Log4NetCore"));
                builder.SetMinimumLevel(LogLevel.Debug);
                builder.AddConsole();
                builder.AddDebug();
            })
            .Build();
    }
}
