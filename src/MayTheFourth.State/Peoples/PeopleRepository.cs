using MayTheFourth.Application.Peoples;
using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Peoples;

public class PeopleRepository(MayTheFourthDbContext context) : IPeopleRepository, IAsyncDisposable
{
    public async Task<IList<People>> GetPeoplesAsync(int? skip, int? take, CancellationToken cancellationToken = default)
    {
        return await context.Peoples
            .AsNoTracking()
            .Include(p => p.Movies)
            .Skip(skip ?? 0)
            .Take(take ?? 10)
            .ToListAsync(cancellationToken);
    }

    public async Task<People> GetPeopleByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return (await context.Peoples
            .AsNoTracking()
            .Include(p => p.Movies)
            .Where(p => p.Id == id)
            .FirstOrDefaultAsync(cancellationToken))!;
    }

    public async Task<IList<People>> GetPeopleByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return (await context.Peoples
            .AsNoTracking()
            .Include(p => p.Movies)
            .Where(p => p.Name.Contains(name))
            .ToListAsync(cancellationToken))!;
    }

    public async Task<IList<People>> GetPeopleByGenderAsync(string gender, CancellationToken cancellationToken = default)
    {
        return (await context.Peoples
            .AsNoTracking()
            .Include(p => p.Movies)
            .Where(p => p.Gender.Contains(gender))
            .ToListAsync(cancellationToken))!;
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();
}