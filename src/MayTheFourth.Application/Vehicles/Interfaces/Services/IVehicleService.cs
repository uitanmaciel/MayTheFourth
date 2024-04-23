namespace MayTheFourth.Application.Vehicles.Interfaces.Services;

public interface IVehicleService
{
    Task<Result<VehicleModel>> SearchByName(string name, CancellationToken cancellationToken = default);
    Task<Result<VehicleModel>> SearchByClass(string @class, CancellationToken cancellationToken = default);
    Task<Result<VehicleModel>> SearchByModel(string model, CancellationToken cancellationToken = default);
    Task<Result<VehicleModel>> SearchById(int id, CancellationToken cancellationToken = default);
    Task<Result<List<VehicleModel>>> ListAll(CancellationToken cancellationToken = default);
}
