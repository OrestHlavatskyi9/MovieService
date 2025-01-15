using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieService.Core.Abstractions;
using MovieService.DataAccess.DbContext;
using MovieService.DataAccess.Repositories;

namespace MovieService.DataAccess;

public static class DataAccessServicesRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddScoped<IMovieRepository, MovieRepository>();

        services.AddDbContext<MovieServiceDbContext>(options =>
        {
            options.UseInMemoryDatabase("MovieServiceMemDb");
        });

        return services;
    }
}