using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Peoples;
using MayTheFourth.Application.Planets;
using MayTheFourth.Application.Starships;
using MayTheFourth.Application.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Contexts;

public class MayTheFourthDbContext(DbContextOptions<MayTheFourthDbContext> optionsBuilderOptions) : DbContext(optionsBuilderOptions)
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<People> Peoples { get; set; }
    public DbSet<Planet> Planets { get; set; }
    public DbSet<Starship> Starships { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=wwwroot/maythefourth.db");
}