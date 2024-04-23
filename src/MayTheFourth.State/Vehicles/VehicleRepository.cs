using MayTheFourth.Application.Vehicles;
using MayTheFourth.Application.Vehicles.Interfaces.State;

namespace MayTheFourth.State.Vehicles;

public class VehicleRepository : IVehicleRepository
{
    public Task<List<VehicleModel>> ListAll(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<VehicleModel> SearchByClass(string @class, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<VehicleModel> SearchById(int id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<VehicleModel> SearchByModel(string model, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<VehicleModel> SearchByName(string name, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
