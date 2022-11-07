using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using WinUISample.Applicationz.Common.Behaviours;
using WinUISample.Applicationz.Contacts.ViewModel;

namespace WinUISample.Applicationz;

public static class ConfigureDI
{
    public static IServiceCollection ConfigureApplicationDI(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        services.AddTransient<IContactViewModel, ContactViewModel>();

        return services;
    }
}
