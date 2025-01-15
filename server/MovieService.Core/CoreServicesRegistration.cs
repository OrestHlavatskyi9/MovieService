using Microsoft.Extensions.DependencyInjection;
using MovieService.Core.Services;

namespace MovieService.Core;

public static class CoreServicesRegistration
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddScoped<IMovieService, Services.MovieService>();

        return services;
    }
}