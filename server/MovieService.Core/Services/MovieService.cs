using MovieService.Core.Abstractions;
using MovieService.Core.Models;
using MovieService.Core.Shared;

namespace MovieService.Core.Services;

internal class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;
    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public ICollection<Movie> GetAllMovies() => _movieRepository.GetAll().ToList();

    public ICollection<Movie> GetMoviesBySearchingCriteria(SearchingCriteria searchingCriteria)
    {
        var allMovies = _movieRepository.GetAll();

        var filteredMovies = allMovies.Where(m => m.Title.ToLower().Contains(searchingCriteria.title.ToLower()));

        return filteredMovies.ToList();
    }
}