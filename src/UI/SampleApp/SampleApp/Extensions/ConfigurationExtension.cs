using Microsoft.Extensions.DependencyInjection;
using WinUISample.Applicationz;
using WinUISample.Infrastructure;

namespace SampleApp.Extensions
{
    public static class ConfigurationExtension
    {
        public static IServiceCollection ConfigureDI(this IServiceCollection serviceCollection)
        {

            serviceCollection.ConfigureApplicationDI();

            serviceCollection.ConfigureInfrastructureDI();

            return serviceCollection;
        }
    }
}
