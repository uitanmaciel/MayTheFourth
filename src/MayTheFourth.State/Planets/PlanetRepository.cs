using MayTheFourth.Application.Planets;
using MayTheFourth.Application.Planets.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Planets;

public class PlanetRepository(MayTheFourthDbContext context) : IPlanetRepository, IAsyncDisposable
{
    public async Task<IList<Planet>> GetPlanetsAsync(int? skip, int? take, CancellationToken cancellationToken = default)
    {
        return await context.Planets
            .AsNoTracking()
            .Include(p => p.Peoples)
            .Include(p => p.Movies)
            .Skip(skip ?? 0)
            .Take(take ?? 10)
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Planet>> GetPlanetByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return await context.Planets
            .AsNoTracking()
            .Include(p => p.Peoples)
            .Include(p => p.Movies)
            .Where(p => p.Name.Contains(name))
            .ToListAsync(cancellationToken);
    }

    public async Task<Planet> GetPlanetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return (await context.Planets
            .AsNoTracking()
            .Include(p => p.Peoples)
            .Include(p => p.Movies)
            .Where(p => p.Id == id)
            .FirstOrDefaultAsync(cancellationToken))!;
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();
}