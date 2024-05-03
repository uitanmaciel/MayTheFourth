using MayTheFourth.Application.Vehicles;
using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Vehicles;

public class VehicleRepository(MayTheFourthDbContext context) : IVehicleRepository, IAsyncDisposable
{
    public async Task<IList<Vehicle>> GetVehiclesAsync(int? skip, int? take, CancellationToken cancellationToken = default)
    {
        return await context.Vehicles
            .AsNoTracking()
            .Include(v => v.Movies)
            .Skip(skip ?? 0)
            .Take(take ?? 10)
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Vehicle>> GetVehicleByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return await context.Vehicles
            .AsNoTracking()
            .Include(v => v.Movies)
            .Where(v => v.Name.Contains(name))
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Vehicle>> GetVehicleByModelAsync(string model, CancellationToken cancellationToken = default)
    {
        return await context.Vehicles
            .AsNoTracking()
            .Include(v => v.Movies)
            .Where(v => v.Model.Contains(model))
            .ToListAsync(cancellationToken);
    }

    public async Task<IList<Vehicle>> GetVehicleByClassAsync(string @class, CancellationToken cancellationToken = default)
    {
        return await context.Vehicles
            .AsNoTracking()
            .Include(v => v.Movies)
            .Where(v => v.Class.Contains(@class))
            .ToListAsync(cancellationToken);
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();
}