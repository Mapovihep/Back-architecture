using Autofac.Extensions.DependencyInjection;

namespace Levi_Inventarization_Backend
{
    public class HostBuilder
    {





        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Program>();
            });
    }
}
