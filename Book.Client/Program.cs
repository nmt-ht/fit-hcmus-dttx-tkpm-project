using Book.Infrastructure.DataAccess.Data;
using Book.Infrastructure.DataAccess.DbAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookManagement
{
    public static class Program
    {
        //public static IConfiguration Configuration;
        //[STAThread]
        //static void Main()
        //{
        //    var builder = new ConfigurationBuilder()
        //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        //    Configuration = builder.Build();

        //    ApplicationConfiguration.Initialize();
        //    Application.Run(new Dashboard());
        //}

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            Application.Run(host.Services.GetRequiredService<Dashboard>());
        }
        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton(context.Configuration);
                    services.AddTransient<Dashboard>();
                    services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
                    services.AddSingleton<IUserData, UserData>();
                });
    }
}