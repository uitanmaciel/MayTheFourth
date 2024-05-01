using MayTheFourth.Application.Planets;
using MayTheFourth.Application.Planets.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Planets;

public class PlanetRepository(MayTheFourthDbContext context) : IPlanetRepository, IAsyncDisposable
{
    public async Task<IList<Planet>> GetPlanetsAsync(CancellationToken cancellationToken = default)
    {
        var planets = await context.Planets
            .AsNoTracking()
            .GroupBy(p => p.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);

        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => planets.Select(x => x.Code).Contains(p.PlanetCode))
            .ToListAsync(cancellationToken);

        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => planets.Select(p => p.Code).Contains(m.PlanetCode))
            .ToListAsync(cancellationToken);
        
        foreach (var planet in planets)
            planet.Peoples = peoples.Where(p => p.PlanetCode == planet.Code).ToList();
        
        foreach (var planet in planets)
            planet.Movies = movies.Where(m => m.PlanetCode == planet.Code).ToList();
        
        return planets;
    }

    public async Task<IList<Planet>> GetPlanetByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => p.Name.Contains(name))
            .GroupBy(p => p.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);

        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => planets.Select(x => x.Code).Contains(p.PlanetCode))
            .ToListAsync(cancellationToken);

        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => planets.Select(p => p.Code).Contains(m.PlanetCode))
            .ToListAsync(cancellationToken);
        
        foreach (var planet in planets)
            planet.Peoples = peoples.Where(p => p.PlanetCode == planet.Code).ToList();
        
        foreach (var planet in planets)
            planet.Movies = movies.Where(m => m.PlanetCode == planet.Code).ToList();
        
        return planets;
    }

    public async Task<Planet> GetPlanetByCodeAsync(int code, CancellationToken cancellationToken = default)
    {
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => p.Code == code)
            .GroupBy(p => p.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);

        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => planets.Select(x => x.Code).Contains(p.PlanetCode))
            .ToListAsync(cancellationToken);

        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => planets.Select(p => p.Code).Contains(m.PlanetCode))
            .ToListAsync(cancellationToken);
        
        foreach (var planet in planets)
            planet.Peoples = peoples.Where(p => p.PlanetCode == planet.Code).ToList();
        
        foreach (var planet in planets)
            planet.Movies = movies.Where(m => m.PlanetCode == planet.Code).ToList();
        
        return planets[0];
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();
}