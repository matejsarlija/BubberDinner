using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Application.Common.Interfaces.Authentication;
using Microsoft.Extensions.DependencyInjection;
using BuberDinner.Application.Common.Services;
using BuberDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;

namespace BuberDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;

    }
}
