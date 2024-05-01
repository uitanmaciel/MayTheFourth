using MayTheFourth.Application.Starships;
using MayTheFourth.Application.Starships.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Starships;

public class StarshipRepository(MayTheFourthDbContext context) : IStarshipRepository, IAsyncDisposable
{
    public async Task<IList<Starship>> GetStarshipsAsync(CancellationToken cancellationToken = default)
    {
        var starships = await context.Starships
            .AsNoTracking()
            .GroupBy(s => s.Code)
            .Select(x => x.First())
            .ToListAsync(cancellationToken);

        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => starships.Select(s => s.Code).Contains(m.StarshipCode))
            .ToListAsync(cancellationToken);
        
        foreach (var starship in starships)
            starship.Movies = movies.Where(m => m.StarshipCode == starship.Code).ToList();
        
        return starships;
    }

    public async Task<IList<Starship>> GetStarshipByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        var starships = await context.Starships
            .AsNoTracking()
            .Where(s => s.Name.Contains(name))
            .GroupBy(s => s.Code)
            .Select(x => x.First())
            .ToListAsync(cancellationToken);

        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => starships.Select(s => s.Code).Contains(m.StarshipCode))
            .ToListAsync(cancellationToken);
        
        foreach (var starship in starships)
            starship.Movies = movies.Where(m => m.StarshipCode == starship.Code).ToList();
        
        return starships;
    }

    public async Task<IList<Starship>> GetStarshipByModelAsync(string model, CancellationToken cancellationToken = default)
    {
        var starships = await context.Starships
            .AsNoTracking()
            .Where(s => s.Model.Contains(model))
            .GroupBy(s => s.Code)
            .Select(x => x.First())
            .ToListAsync(cancellationToken);

        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => starships.Select(s => s.Code).Contains(m.StarshipCode))
            .ToListAsync(cancellationToken);
        
        foreach (var starship in starships)
            starship.Movies = movies.Where(m => m.StarshipCode == starship.Code).ToList();
        
        return starships;
    }

    public async Task<IList<Starship>> GetStarshipByClassAsync(string @class, CancellationToken cancellationToken = default)
    {
        var starships = await context.Starships
            .AsNoTracking()
            .Where(s => s.Class.Contains(@class))
            .GroupBy(s => s.Code)
            .Select(x => x.First())
            .ToListAsync(cancellationToken);

        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => starships.Select(s => s.Code).Contains(m.StarshipCode))
            .ToListAsync(cancellationToken);
        
        foreach (var starship in starships)
            starship.Movies = movies.Where(m => m.StarshipCode == starship.Code).ToList();
        
        return starships;
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();
}