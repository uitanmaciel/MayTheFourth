using MayTheFourth.Application.Peoples;
using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Peoples;

public class PeopleRepository(MayTheFourthDbContext context) : IPeopleRepository, IAsyncDisposable
{
    public async Task<IList<People>> GetPeoplesAsync(CancellationToken cancellationToken = default)
    {
        var peoples = await context.Peoples
            .AsNoTracking()
            .GroupBy(p => p.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => peoples.Select(x => x.Code).Contains(p.CharacterCode))
            .ToListAsync(cancellationToken);
        
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => peoples.Select(x => x.Code).Contains(m.CharacterCode))
            .ToListAsync(cancellationToken);

        foreach (var people in peoples)
            people.Planets = planets.Where(p => p.CharacterCode == people.Code).ToList();
        
        foreach (var people in peoples)
            people.Movies = movies.Where(m => m.CharacterCode == people.Code).ToList();
        
        return peoples;
    }

    public async Task<People> GetPeopleByCodeAsync(int code, CancellationToken cancellationToken = default)
    {
        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => p.Code == code)
            .GroupBy(p => p.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => peoples.Select(x => x.Code).Contains(p.CharacterCode))
            .ToListAsync(cancellationToken);
        
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => peoples.Select(x => x.Code).Contains(m.CharacterCode))
            .ToListAsync(cancellationToken);

        foreach (var people in peoples)
            people.Planets = planets.Where(p => p.CharacterCode == people.Code).ToList();
        
        foreach (var people in peoples)
            people.Movies = movies.Where(m => m.CharacterCode == people.Code).ToList();
        
        return peoples[0];
    }

    public async Task<IList<People>> GetPeopleByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => p.Name.Contains(name))
            .GroupBy(p => p.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => peoples.Select(x => x.Code).Contains(p.CharacterCode))
            .ToListAsync(cancellationToken);
        
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => peoples.Select(x => x.Code).Contains(m.CharacterCode))
            .ToListAsync(cancellationToken);

        foreach (var people in peoples)
            people.Planets = planets.Where(p => p.CharacterCode == people.Code).ToList();
        
        foreach (var people in peoples)
            people.Movies = movies.Where(m => m.CharacterCode == people.Code).ToList();
        
        return peoples;
    }

    public async Task<IList<People>> GetPeopleByGenderAsync(string gender, CancellationToken cancellationToken = default)
    {
        var peoples = await context.Peoples
            .AsNoTracking()
            .Where(p => p.Gender.Contains(gender))
            .GroupBy(p => p.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var planets = await context.Planets
            .AsNoTracking()
            .Where(p => peoples.Select(x => x.Code).Contains(p.CharacterCode))
            .ToListAsync(cancellationToken);
        
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => peoples.Select(x => x.Code).Contains(m.CharacterCode))
            .ToListAsync(cancellationToken);

        foreach (var people in peoples)
            people.Planets = planets.Where(p => p.CharacterCode == people.Code).ToList();
        
        foreach (var people in peoples)
            people.Movies = movies.Where(m => m.CharacterCode == people.Code).ToList();
        
        return peoples;
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();
}