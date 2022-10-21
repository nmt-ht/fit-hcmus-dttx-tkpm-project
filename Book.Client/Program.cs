using Book.Business;
using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Infrastructure.DataAccess.DbAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookManagement
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            Application.Run(host.Services.GetRequiredService<Dashboard>());
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
                    services.AddTransient<Dashboard>();
                    //Init DI for Bussiness class
                    services.AddSingleton<IUserBiz, UserBiz>();
                    //Init DI for DAL class
                    services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
                    services.AddSingleton<IUserData, UserData>();
                });
    }
}