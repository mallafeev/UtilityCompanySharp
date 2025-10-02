using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CourseWorkPIPS.Services;
using CourseWorkPIPS.Repositories;
using CourseWorkPIPS.Database;

using CourseWorkPIPS.Repositories.IRepo;
using CourseWorkPIPS.Repositories.Repo;
using CourseWorkPIPS.Services.IServ;
using CourseWorkPIPS.Services.Serv;
using Serilog;
using Microsoft.VisualBasic.Logging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CourseWorkPIPS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Serilog.Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
                .MinimumLevel.Information()
                .Filter.ByExcluding(logEvent =>
                    logEvent.MessageTemplate.Text.Contains("Executed DbCommand") ||
                    logEvent.MessageTemplate.Text.Contains("Microsoft.EntityFrameworkCore.Database.Command"))
                .CreateLogger();
            var host = CreateHostBuilder().Build();
            ApplicationConfiguration.Initialize();
            Application.Run(host.Services.GetRequiredService<StartForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .UseSerilog()
                .ConfigureServices((_, services) =>
                {
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseNpgsql("Host=localhost;Port=5432;Database=PassDB;Username=postgres;Password=postgres"));
                    services.AddScoped<IPassRepository, PassRepository>();
                    services.AddScoped<IPassService, PassService>();
                    services.AddScoped<IAddressRepository, AddressRepository>();
                    services.AddScoped<IAddressService, AddressService>();

                    services.AddTransient<PassForm>();
                    services.AddTransient<PassesForm>();
                    services.AddTransient<AddressForm>();
                    services.AddTransient<AddressesForm>();
                    services.AddTransient<StartForm>();
                    services.AddTransient<Static>();
                });

        }
    }
}