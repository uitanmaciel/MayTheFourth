using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.Application.Vehicles.Queries;

namespace MayTheFourth.Application.Vehicles.QueriesHandlers;

public class GetVehicleByClassQueryHandler(IVehicleRepository repository) : IRequestHandler<GetVehicleByClassQuery, IList<Vehicle>>
{
    public async Task<IList<Vehicle>> Handle(GetVehicleByClassQuery request, CancellationToken cancellationToken)
        => await repository.GetVehicleByClassAsync(request.Class, cancellationToken);
}