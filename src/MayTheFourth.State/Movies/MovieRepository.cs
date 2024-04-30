using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Movies;

public class MovieRepository(MayTheFourthDbContext context) : IMovieRepository, IAsyncDisposable
{
    public async Task<IList<Movie>> SearchByTitleAsync(string title, CancellationToken cancellationToken = default)
    {
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => m.Title.Contains(title))
            .GroupBy(m => m.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var vehicles = await context.Vehicles
            .AsNoTracking()
            .Where(v => movies.Select(m => m.Code).Contains(v.MovieCode))
            .ToListAsync(cancellationToken);
        
        var starships = await context.Starships
            .AsNoTracking()
            .Where(s => movies.Select(m => m.Code).Contains(s.MovieCode))
            .ToListAsync(cancellationToken);
        
        foreach (var movie in movies)
            movie.Planets = planets.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Characters = peoples.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Vehicles = vehicles.Where(v => v.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Starships = starships.Where(s => s.MovieCode == movie.Code).ToList();
        
        return movies;
    }

    public async Task<IList<Movie>> SearchByDirectorAsync(string director, CancellationToken cancellationToken = default)
    {
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => m.Director.Contains(director))
            .GroupBy(m => m.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var vehicles = await context.Vehicles
            .AsNoTracking()
            .Where(v => movies.Select(m => m.Code).Contains(v.MovieCode))
            .ToListAsync(cancellationToken);
        
        var starships = await context.Starships
            .AsNoTracking()
            .Where(s => movies.Select(m => m.Code).Contains(s.MovieCode))
            .ToListAsync(cancellationToken);
        
        foreach (var movie in movies)
            movie.Planets = planets.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Characters = peoples.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Vehicles = vehicles.Where(v => v.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Starships = starships.Where(s => s.MovieCode == movie.Code).ToList();
        
        return movies;
    }

    public async Task<IList<Movie>> SearchByProducerAsync(string producer, CancellationToken cancellationToken = default)
    {
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => m.Producer.Contains(producer))
            .GroupBy(m => m.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var vehicles = await context.Vehicles
            .AsNoTracking()
            .Where(v => movies.Select(m => m.Code).Contains(v.MovieCode))
            .ToListAsync(cancellationToken);
        
        var starships = await context.Starships
            .AsNoTracking()
            .Where(s => movies.Select(m => m.Code).Contains(s.MovieCode))
            .ToListAsync(cancellationToken);
        
        foreach (var movie in movies)
            movie.Planets = planets.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Characters = peoples.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Vehicles = vehicles.Where(v => v.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Starships = starships.Where(s => s.MovieCode == movie.Code).ToList();
        
        return movies;
    }

    public async Task<IList<Movie>> SearchByReleaseDateAsync(string releaseDate, CancellationToken cancellationToken = default)
    {
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => m.ReleaseDate.Contains(releaseDate))
            .GroupBy(m => m.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var vehicles = await context.Vehicles
            .AsNoTracking()
            .Where(v => movies.Select(m => m.Code).Contains(v.MovieCode))
            .ToListAsync(cancellationToken);
        
        var starships = await context.Starships
            .AsNoTracking()
            .Where(s => movies.Select(m => m.Code).Contains(s.MovieCode))
            .ToListAsync(cancellationToken);
        
        foreach (var movie in movies)
            movie.Planets = planets.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Characters = peoples.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Vehicles = vehicles.Where(v => v.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Starships = starships.Where(s => s.MovieCode == movie.Code).ToList();
        
        return movies;
    }

    public async Task<IList<Movie>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var movies = await context.Movies
            .AsNoTracking()
            .GroupBy(m => m.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var moviesCodes = movies.Select(m => m.Code);
        
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => movies.Select(m => m.Code).Contains(p.MovieCode))
            .ToListAsync(cancellationToken);
        
        var vehicles = await context.Vehicles
            .AsNoTracking()
            .Where(v => movies.Select(m => m.Code).Contains(v.MovieCode))
            .ToListAsync(cancellationToken);
        
        var starships = await context.Starships
            .AsNoTracking()
            .Where(s => movies.Select(m => m.Code).Contains(s.MovieCode))
            .ToListAsync(cancellationToken);
        
        foreach (var movie in movies)
            movie.Planets = planets.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Characters = peoples.Where(p => p.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Vehicles = vehicles.Where(v => v.MovieCode == movie.Code).ToList();
        
        foreach (var movie in movies)
            movie.Starships = starships.Where(s => s.MovieCode == movie.Code).ToList();
        
        return movies;
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();

    /*private async Task<IList<T>> FilterByMovieCode<T>(IEnumerable<int> movieCodes, CancellationToken cancellationToken) where T : class, IMovieEntity
    
    {
        var entities = await context.Set<T>()
            .AsNoTracking()
            .Where(e => movieCodes.Contains(e.MovieCode))
            .ToListAsync(cancellationToken);
        
        return entities;
    }*/
}