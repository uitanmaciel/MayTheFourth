using MayTheFourth.Application.Vehicles.Interfaces.Services;
using MayTheFourth.Application.Vehicles.Queries;
using MayTheFourth.Application.Vehicles.Responses;

namespace MayTheFourth.Application.Vehicles.Services;

public class VehicleServices(ISender mediator) : IVehicleServices
{
    public async Task<Result<IList<VehicleResponse>>> GetVehiclesAsync(int? skip, int? take, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetVehiclesQuery(skip ?? 0, take ?? 10), cancellationToken);
        if (response is null) return Result<IList<VehicleResponse>>.Failure(Error.NotFound);
        return Result<IList<VehicleResponse>>.Ok(Vehicle.ToResponse(response));
    }

    public async Task<Result<IList<VehicleResponse>>> GetVehicleByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetVehicleByNameQuery(name), cancellationToken);
        if (response is null) return Result<IList<VehicleResponse>>.Failure(Error.NotFound);
        return Result<IList<VehicleResponse>>.Ok(Vehicle.ToResponse(response));
    }

    public async Task<Result<IList<VehicleResponse>>> GetVehicleByModelAsync(string model, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetVehicleByModelQuery(model), cancellationToken);
        if (response is null) return Result<IList<VehicleResponse>>.Failure(Error.NotFound);
        return Result<IList<VehicleResponse>>.Ok(Vehicle.ToResponse(response));
    }

    public async Task<Result<IList<VehicleResponse>>> GetVehicleByClassAsync(string @class, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetVehicleByClassQuery(@class), cancellationToken);
        if (response is null) return Result<IList<VehicleResponse>>.Failure(Error.NotFound);
        return Result<IList<VehicleResponse>>.Ok(Vehicle.ToResponse(response));
    }
}