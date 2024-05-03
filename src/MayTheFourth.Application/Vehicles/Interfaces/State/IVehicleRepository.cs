namespace MayTheFourth.Application.Vehicles.Interfaces.State;

public interface IVehicleRepository
{
    Task<IList<Vehicle>> GetVehiclesAsync(int? skip, int? take, CancellationToken cancellationToken = default);
    Task<IList<Vehicle>> GetVehicleByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<IList<Vehicle>> GetVehicleByModelAsync(string model, CancellationToken cancellationToken = default);
    Task<IList<Vehicle>> GetVehicleByClassAsync(string @class, CancellationToken cancellationToken = default);
}