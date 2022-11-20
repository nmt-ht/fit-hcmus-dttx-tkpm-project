using BookManagement.Business;
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
                    InitFormControl(services);
                    InitServices(services);
                });

        static void InitFormControl(IServiceCollection services)
        {
            services.AddTransient<Dashboard>();
        }

        static void InitServices(IServiceCollection services)
        {
            //Init DI for DAL class
            services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
            services.AddSingleton<IUserData, UserData>();
            services.AddSingleton<IBookData, BookData>();
            services.AddSingleton<IParameterData, ParameterData>();
            services.AddSingleton<ICustomerData, CustomerData>();
            services.AddSingleton<IOrderData, OrderData>();
            services.AddSingleton<IReceiptData, ReceiptData>();
            services.AddSingleton<IInventorySnapshotData, InventorySnapshotData>();

            //Init DI for Bussiness class
            services.AddSingleton<IUserBiz, UserBiz>();
            services.AddSingleton<IBookBiz, BookBiz>();
            services.AddSingleton<IParameterBiz, ParameterBiz>();
            services.AddSingleton<ICustomerBiz, CustomerBiz>();
            services.AddSingleton<IOrderBiz, OrderBiz>();
            services.AddSingleton<IReceiptBiz, ReceiptBiz>();
            services.AddSingleton<IInventorySnapshotBiz, InventorySnapshotBiz>();
        }
    }
}