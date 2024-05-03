using MayTheFourth.Application.Starships;
using MayTheFourth.Application.Starships.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Starships;

public class StarshipRepository(MayTheFourthDbContext context) : IStarshipRepository, IAsyncDisposable
{
    public async Task<IList<Starship>> GetStarshipsAsync(int? skip, int? take, CancellationToken cancellationToken = default)
    {
        return await context.Starships
            .AsNoTracking()
            .Include(s => s.Movies)
            .Skip(skip ?? 0)
            .Take(take ?? 10)
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Starship>> GetStarshipByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return await context.Starships
            .AsNoTracking()
            .Include(s => s.Movies)
            .Where(p => p.Name.Contains(name))
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Starship>> GetStarshipByModelAsync(string model, CancellationToken cancellationToken = default)
    {
        return await context.Starships
            .AsNoTracking()
            .Include(s => s.Movies)
            .Where(p => p.Model.Contains(model))
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Starship>> GetStarshipByClassAsync(string @class, CancellationToken cancellationToken = default)
    {
        return await context.Starships
            .AsNoTracking()
            .Include(s => s.Movies)
            .Where(p => p.Class.Contains(@class))
            .ToListAsync(cancellationToken);
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();
}