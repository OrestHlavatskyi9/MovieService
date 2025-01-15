using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieService.Core.Models;
using MovieService.Core.ValueObjects;

namespace MovieService.DataAccess.Configurations;

internal sealed class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.ReleaseYear).HasConversion(
            releaseYear => releaseYear.Value,
            value => ReleaseYear.Create(value)!);

        builder.Property(m => m.PosterImageUrl).HasConversion(
            posterImageUrl => posterImageUrl.Value,
            value => PosterImageUrl.Create(value)!);
    }
}