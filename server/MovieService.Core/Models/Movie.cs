using MovieService.Core.ValueObjects;

namespace MovieService.Core.Models;

public class Movie
{
    public readonly uint Id;
    public required string Title { get; set; }
    public required PosterImageUrl PosterImageUrl { get; set; }
    public required ReleaseYear ReleaseYear { get; set; }
}