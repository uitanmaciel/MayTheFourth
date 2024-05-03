using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Movies;

public class MovieRepository(MayTheFourthDbContext context) : IMovieRepository, IAsyncDisposable
{
    public async Task<IList<Movie>> SearchByTitleAsync(string title, CancellationToken cancellationToken = default)
    {
        return await context.Movies
            .AsNoTracking()
            .Include(m => m.Characters)
            .Include(m => m.Planets)
            .Include(m => m.Vehicles)
            .Include(m => m.Starships)
            .Where(m => m.Title.Contains(title))
            .ToListAsync(cancellationToken);
    }
        
    

    public async Task<IList<Movie>> SearchByDirectorAsync(string director, CancellationToken cancellationToken = default)
    {
        return await context.Movies
            .AsNoTracking()
            .Include(m => m.Characters)
            .Include(m => m.Planets)
            .Include(m => m.Vehicles)
            .Include(m => m.Starships)
            .Where(m => m.Director.Contains(director))
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Movie>> SearchByProducerAsync(string producer, CancellationToken cancellationToken = default)
    {
        return await context.Movies
            .AsNoTracking()
            .Include(m => m.Characters)
            .Include(m => m.Planets)
            .Include(m => m.Vehicles)
            .Include(m => m.Starships)
            .Where(m => m.Producer.Contains(producer))
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Movie>> SearchByReleaseDateAsync(string releaseDate, CancellationToken cancellationToken = default)
    {
        return await context.Movies
            .AsNoTracking()
            .Include(m => m.Characters)
            .Include(m => m.Planets)
            .Include(m => m.Vehicles)
            .Include(m => m.Starships)
            .Where(m => m.ReleaseDate.Contains(releaseDate))
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Movie>> GetAllAsync(int? skip, int? take, CancellationToken cancellationToken = default)
    {
        return await context.Movies
            .AsNoTracking()
            .Include(m => m.Characters)
            .Include(m => m.Planets)
            .Include(m => m.Vehicles)
            .Include(m => m.Starships)
            .Skip(skip ?? 0)
            .Take(take ?? 10)
            .ToListAsync(cancellationToken);
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();
}