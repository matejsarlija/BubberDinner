using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Application.Common.Interfaces.Authentication;
using Microsoft.Extensions.DependencyInjection;
using BuberDinner.Application.Common.Services;
using BuberDinner.Infrastructure.Services;

namespace BuberDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;

    }
}
