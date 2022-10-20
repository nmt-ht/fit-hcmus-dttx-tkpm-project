using Book.Infrastructure.DataAccess.Data;
using Book.Infrastructure.DataAccess.DbAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Book.Client.Dialog;

namespace BookManagement
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            Application.Run(host.Services.GetRequiredService<frmLogin>());
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((host, config) =>
            {
                var settingFile = "appsettings.json";
                config.AddJsonFile(settingFile, optional: false, reloadOnChange: true);
            }).ConfigureServices((context, services) =>
                {
                    services.AddSingleton(context.Configuration);
                    services.AddTransient<frmLogin>();
                    services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
                    services.AddSingleton<IUserData, UserData>();
                });
    }
}