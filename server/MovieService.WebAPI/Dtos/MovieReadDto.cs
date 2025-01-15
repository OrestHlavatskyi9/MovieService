namespace MovieService.WebAPI.Dtos;

public sealed record MovieReadDto(uint Id, string Title, string PosterImageUrl, int ReleaseYear);