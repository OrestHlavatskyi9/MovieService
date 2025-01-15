using MovieService.Core.Models;

namespace MovieService.Core.Abstractions;

public interface IMovieRepository
{
    IQueryable<Movie> GetAll();
}
