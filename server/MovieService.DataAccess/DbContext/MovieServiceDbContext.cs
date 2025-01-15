using Microsoft.EntityFrameworkCore;
using MovieService.Core.Models;

namespace MovieService.DataAccess.DbContext;

internal sealed class MovieServiceDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public MovieServiceDbContext(DbContextOptions<MovieServiceDbContext> options) : base(options) { }

    public DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieServiceDbContext).Assembly);
    }
}