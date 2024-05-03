using MayTheFourth.Application.Vehicles.Responses;

namespace MayTheFourth.Application.Vehicles.Interfaces.Services;

public interface IVehicleServices
{
    Task<Result<IList<VehicleResponse>>> GetVehiclesAsync(int? skip, int? take, CancellationToken cancellationToken = default);
    Task<Result<IList<VehicleResponse>>> GetVehicleByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<Result<IList<VehicleResponse>>> GetVehicleByModelAsync(string model, CancellationToken cancellationToken = default);
    Task<Result<IList<VehicleResponse>>> GetVehicleByClassAsync(string @class, CancellationToken cancellationToken = default);
}