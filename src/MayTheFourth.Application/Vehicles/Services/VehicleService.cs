using MayTheFourth.Application.Vehicles.Interfaces.Services;
using MayTheFourth.Application.Vehicles.Queries;
using MediatR;

namespace MayTheFourth.Application.Vehicles.Services;

public class VehicleService(IMediator mediator) : IVehicleService
{
    public async Task<Result<List<VehicleModel>>> ListAll(CancellationToken cancellationToken = default)
    {
        var vehicles = await mediator.Send(new ListAllQuery(), cancellationToken);
        if (vehicles is null)
            return Result<List<VehicleModel>>.Failure(Error.NotFound);

        return Result<List<VehicleModel>>.Ok(vehicles);
    }

    public async Task<Result<VehicleModel>> SearchByClass(string @class, CancellationToken cancellationToken = default)
    {
        var vehicle = await mediator.Send(new SearchByClassQuery(@class), cancellationToken);
        if (vehicle is null)
            return Result<VehicleModel>.Failure(Error.NotFound);

        return Result<VehicleModel>.Ok(vehicle);
    }

    public async Task<Result<VehicleModel>> SearchByModel(string model, CancellationToken cancellationToken = default)
    {
        var vehicle = await mediator.Send(new SearchByModelQuery(model), cancellationToken);
        if (vehicle is null)
            return Result<VehicleModel>.Failure(Error.NotFound);

        return Result<VehicleModel>.Ok(vehicle);
    }

    public async Task<Result<VehicleModel>> SearchById(int id, CancellationToken cancellationToken = default)
    {
        var vehicle = await mediator.Send(new SearchByIdQuery(id), cancellationToken);
        if (vehicle is null)
            return Result<VehicleModel>.Failure(Error.NotFound);

        return Result<VehicleModel>.Ok(vehicle);
    }

    public async Task<Result<VehicleModel>> SearchByName(string name, CancellationToken cancellationToken = default)
    {
        var vehicle = await mediator.Send(new SearchByNameQuery(name), cancellationToken);
        if (vehicle is null)
            return Result<VehicleModel>.Failure(Error.NotFound);

        return Result<VehicleModel>.Ok(vehicle);
    }
}
