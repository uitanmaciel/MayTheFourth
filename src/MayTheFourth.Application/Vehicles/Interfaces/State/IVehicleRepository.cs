namespace MayTheFourth.Application.Vehicles.Interfaces.State;

public interface IVehicleRepository
{
    Task<VehicleModel> SearchByName(string name, CancellationToken cancellationToken = default);
    Task<VehicleModel> SearchByClass(string @class, CancellationToken cancellationToken = default);
    Task<VehicleModel> SearchByModel(string model, CancellationToken cancellationToken = default);
    Task<VehicleModel> SearchById(int id, CancellationToken cancellationToken = default);
    Task<List<VehicleModel>> ListAll(CancellationToken cancellationToken = default);
}
