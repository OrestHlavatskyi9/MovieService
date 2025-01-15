using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieService.Core.Services;
using MovieService.Core.Shared;
using MovieService.WebAPI.Dtos;

namespace MovieService.WebAPI.Controllers;

public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;
    private readonly IMapper _mapper;
    public MovieController(IMovieService movieService, IMapper mapper)
    {
        _movieService = movieService;
        _mapper = mapper;
    }

    [HttpGet, Route("")]
    public async Task<IActionResult> GetAllMovies()
    {
        var movies = await Task.FromResult(_movieService.GetAllMovies());

        return Ok(_mapper.Map<List<MovieReadDto>>(movies));
    }

    [HttpGet("s")]
    public async Task<IActionResult> GetMovieByCriteria([FromQuery] string title)
    {
        var searchingCriteria = new SearchingCriteria(title);

        var filteredMovies = await Task.FromResult(_movieService.GetMoviesBySearchingCriteria(searchingCriteria));

        return Ok(_mapper.Map<List<MovieReadDto>>(filteredMovies));
    }
}