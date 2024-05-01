using MayTheFourth.Application.Vehicles;
using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.State.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.State.Vehicles;

public class VehicleRepository(MayTheFourthDbContext context) : IVehicleRepository, IAsyncDisposable
{
    public async Task<IList<Vehicle>> GetVehiclesAsync(CancellationToken cancellationToken = default)
    {
        var vehicles = await context.Vehicles
            .AsNoTracking()
            .GroupBy(v => v.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => vehicles.Select(v => v.Code).Contains(m.VehicleCode))
            .ToListAsync(cancellationToken);
        
        foreach (var vehicle in vehicles)
            vehicle.Movies = movies.Where(m => m.VehicleCode == vehicle.Code).ToList();
        
        return vehicles;
    }

    public async Task<IList<Vehicle>> GetVehicleByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        var vehicles = await context.Vehicles
            .AsNoTracking()
            .Where(v => v.Name.Contains(name))
            .GroupBy(v => v.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => vehicles.Select(v => v.Code).Contains(m.VehicleCode))
            .ToListAsync(cancellationToken);
        
        foreach (var vehicle in vehicles)
            vehicle.Movies = movies.Where(m => m.VehicleCode == vehicle.Code).ToList();
        
        return vehicles;
    }

    public async Task<IList<Vehicle>> GetVehicleByModelAsync(string model, CancellationToken cancellationToken = default)
    {
        var vehicles = await context.Vehicles
            .AsNoTracking()
            .Where(v => v.Model.Contains(model))
            .GroupBy(v => v.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => vehicles.Select(v => v.Code).Contains(m.VehicleCode))
            .ToListAsync(cancellationToken);
        
        foreach (var vehicle in vehicles)
            vehicle.Movies = movies.Where(m => m.VehicleCode == vehicle.Code).ToList();
        
        return vehicles;
    }

    public async Task<IList<Vehicle>> GetVehicleByClassAsync(string @class, CancellationToken cancellationToken = default)
    {
        var vehicles = await context.Vehicles
            .AsNoTracking()
            .Where(v => v.Class.Contains(@class))
            .GroupBy(v => v.Code)
            .Select(c => c.First())
            .ToListAsync(cancellationToken);
        
        var movies = await context.Movies
            .AsNoTracking()
            .Where(m => vehicles.Select(v => v.Code).Contains(m.VehicleCode))
            .ToListAsync(cancellationToken);
        
        foreach (var vehicle in vehicles)
            vehicle.Movies = movies.Where(m => m.VehicleCode == vehicle.Code).ToList();
        
        return vehicles;
    }

    public async ValueTask DisposeAsync() => await context.DisposeAsync();
}