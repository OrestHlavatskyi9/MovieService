using AutoMapper;
using MovieService.Core.Models;
using MovieService.Core.ValueObjects;
using MovieService.WebAPI.Dtos;

namespace MovieService.WebAPI.Profiles;

public sealed class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<ReleaseYear, int>().ConvertUsing(src => src.Value);
        CreateMap<PosterImageUrl, string>().ConvertUsing(src => src.Value);

        CreateMap<Movie, MovieReadDto>()
            .ForMember(dest => dest.PosterImageUrl,
                       opt => opt.MapFrom(src => src.PosterImageUrl.Value))
            .ForMember(dest => dest.ReleaseYear,
                       opt => opt.MapFrom(src => src.ReleaseYear.Value));
    }
}