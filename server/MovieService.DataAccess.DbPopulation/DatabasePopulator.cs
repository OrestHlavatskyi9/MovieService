using Microsoft.Extensions.DependencyInjection;
using MovieService.DataAccess.DbContext;
using MovieService.Core.Models;
using MovieService.Core.ValueObjects;

namespace MovieService.DataAccess.DbPopulation;

public static class DatabasePopulator
{
    public async static void PopulateDbAsync(Microsoft.AspNetCore.Builder.IApplicationBuilder applicationBuilder)
    {
        using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            await SeedMovies(serviceScope);
        }
    }

    private async static Task SeedMovies(IServiceScope serviceScope)
    {
        var services = serviceScope.ServiceProvider;

        var context = services.GetRequiredService<MovieServiceDbContext>();

        await context.Movies.AddRangeAsync(GetMovies());

        await context.SaveChangesAsync();
    }

    private static Movie[] GetMovies() =>
        [
            new Movie
            {
                Title = "First Movie",
                PosterImageUrl = PosterImageUrl.Create("https://cdn.shopify.com/s/files/1/0830/9575/files/dune-part-two-movie-poster-matt-ferguson_ac86f8c9-f410-450c-805b-c4352aac4a55_540x.jpg?v=1730814717")!,
                ReleaseYear = ReleaseYear.Create(2004)!
            },
            new Movie
            {
                Title = "Second Movie",
                PosterImageUrl = PosterImageUrl.Create("https://marketplace.canva.com/EAFTl0ixW_k/1/0/1131w/canva-black-white-minimal-alone-movie-poster-YZ-0GJ13Nc8.jpg")!,
                ReleaseYear = ReleaseYear.Create(1930)!
            },
            new Movie
            {
                Title = "Third Movie",
                PosterImageUrl = PosterImageUrl.Create("https://cdn.shopify.com/s/files/1/0830/9575/files/dune-part-two-movie-poster-matt-ferguson_ac86f8c9-f410-450c-805b-c4352aac4a55_540x.jpg?v=1730814717")!,
                ReleaseYear = ReleaseYear.Create(2022)!
            },
            new Movie
            {
                Title = "Fifth Movie",
                PosterImageUrl = PosterImageUrl.Create("https://intheposter.com/cdn/shop/files/the-manager-in-the-poster-1.jpg?v=1733910535")!,
                ReleaseYear = ReleaseYear.Create(2024)!
            },
            new Movie
            {
                Title = "Sixth Movie",
                PosterImageUrl = PosterImageUrl.Create("https://cdn.shopify.com/s/files/1/0830/9575/files/dune-part-two-movie-poster-matt-ferguson_ac86f8c9-f410-450c-805b-c4352aac4a55_540x.jpg?v=1730814717")!,
                ReleaseYear = ReleaseYear.Create(2007)!
            },
            new Movie
            {
                Title = "Seventh Movie",
                PosterImageUrl = PosterImageUrl.Create("https://cdn.shopify.com/s/files/1/0830/9575/files/dune-part-two-movie-poster-matt-ferguson_ac86f8c9-f410-450c-805b-c4352aac4a55_540x.jpg?v=1730814717")!,
                ReleaseYear = ReleaseYear.Create(2000)!
            },
            new Movie
            {
                Title = "Nineth Movie",
                PosterImageUrl = PosterImageUrl.Create("https://intheposter.com/cdn/shop/products/you-in-space-in-the-poster-1.jpg?v=1733910543")!,
                ReleaseYear = ReleaseYear.Create(2010)!
            },
            new Movie
            {
                Title = "Tenth Movie",
                PosterImageUrl = PosterImageUrl.Create("https://cdn.shopify.com/s/files/1/0830/9575/files/dune-part-two-movie-poster-matt-ferguson_ac86f8c9-f410-450c-805b-c4352aac4a55_540x.jpg?v=1730814717")!,
                ReleaseYear = ReleaseYear.Create(2012)!
            },
            new Movie
            {
                Title = "Eleventh Movie",
                PosterImageUrl = PosterImageUrl.Create("https://cdn.shopify.com/s/files/1/0830/9575/files/dune-part-two-movie-poster-matt-ferguson_ac86f8c9-f410-450c-805b-c4352aac4a55_540x.jpg?v=1730814717")!,
                ReleaseYear = ReleaseYear.Create(1963)!
            },
            new Movie
            {
                Title = "Tweflth Movie",
                PosterImageUrl = PosterImageUrl.Create("https://intheposter.com/cdn/shop/products/you-in-space-in-the-poster-1.jpg?v=1733910543")!,
                ReleaseYear = ReleaseYear.Create(1994)!
            },
        ];
}