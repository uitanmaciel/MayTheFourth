using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.Application.Vehicles.Queries;

namespace MayTheFourth.Application.Vehicles.QueriesHandlers;

public class GetVehicleByModelQueryHandler(IVehicleRepository repository) : IRequestHandler<GetVehicleByModelQuery, IList<Vehicle>>
{
    public async Task<IList<Vehicle>> Handle(GetVehicleByModelQuery request, CancellationToken cancellationToken)
        => await repository.GetVehicleByModelAsync(request.Model, cancellationToken);
}