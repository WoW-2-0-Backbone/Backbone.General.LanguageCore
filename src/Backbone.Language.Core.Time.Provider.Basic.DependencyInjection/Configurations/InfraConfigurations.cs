using Backbone.Language.Core.Time.Provider.Abstractions.Brokers;
using Backbone.Language.Core.Time.Provider.Basic.Brokers;
using Microsoft.Extensions.DependencyInjection;

namespace Backbone.Language.Core.Time.Provider.Basic.DependencyInjection.Configurations;

/// <summary>
/// Contains extension methods to configure the time related dependencies.
/// </summary>
public static class InfraConfigurations
{
    /// <summary>
    /// Registers time provider dependencies.
    /// </summary>
    /// <param name="services">The service collection to add time provider to.</param>
    /// <returns></returns>
    public static IServiceCollection AddTimeProvider(this IServiceCollection services)
    {
        services
            .AddSingleton(TimeProvider.System)
            .AddSingleton<ITimeProvider, BasicTimeProvider>();

        return services;
    }
}