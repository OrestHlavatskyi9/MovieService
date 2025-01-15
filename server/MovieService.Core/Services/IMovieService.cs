using MovieService.Core.Models;
using MovieService.Core.Shared;

namespace MovieService.Core.Services;
public interface IMovieService
{
    ICollection<Movie> GetAllMovies();
    ICollection<Movie> GetMoviesBySearchingCriteria(SearchingCriteria searchingCriteria);
}