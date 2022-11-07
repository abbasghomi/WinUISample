using Microsoft.Extensions.DependencyInjection;
using WinUISample.Applicationz.Common.Interfaces.Repositories;
using WinUISample.Infrastructure.Persistence;
using WinUISample.Infrastructure.Persistence.Repositories;

namespace WinUISample.Infrastructure;

public static class ConfigureDI
{
    public static IServiceCollection ConfigureInfrastructureDI(this IServiceCollection services)
    {
        services.AddSingleton<IDataStorage, DataStorage>();

        services.AddTransient<IContactRepository, ContactRepository>();

        return services;
    }
}
