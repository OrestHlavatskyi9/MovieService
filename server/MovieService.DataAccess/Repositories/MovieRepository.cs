using MovieService.Core.Abstractions;
using MovieService.Core.Models;
using MovieService.DataAccess.DbContext;

namespace MovieService.DataAccess.Repositories;

internal class MovieRepository : IMovieRepository
{
    private readonly MovieServiceDbContext _context;
    public MovieRepository(MovieServiceDbContext movieServiceDbContext)
    {
        _context = movieServiceDbContext;
    }

    public IQueryable<Movie> GetAll() => _context.Movies;
}