using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ItemFormatter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //var host = Host.CreateDefaultBuilder()
            //    .ConfigureAppConfiguration((context, builder) =>
            //    {
            //        // Add other configuration files...
            //        builder.AddJsonFile("appsettings.json", optional: true);
            //    })
            //    .ConfigureServices((context, services) => { ConfigureServices(context.Configuration, services); })
            //    .ConfigureLogging(logging =>
            //    {
            //        // Add other loggers...
            //    })
            //    .Build();

            //var services = host.Services;
            //var mainForm = services.GetRequiredService<Main>();
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            ////Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(mainForm);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        //private static void ConfigureServices(IConfiguration configuration,
        //    IServiceCollection services)
        //{
        //    services.AddSingleton<Main>();
        //    //services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
        //}
    }
}
