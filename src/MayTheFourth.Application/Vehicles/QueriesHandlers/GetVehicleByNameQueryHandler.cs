using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.Application.Vehicles.Queries;

namespace MayTheFourth.Application.Vehicles.QueriesHandlers;

public class GetVehicleByNameQueryHandler(IVehicleRepository repository) : IRequestHandler<GetVehicleByNameQuery, IList<Vehicle>>
{
    public async Task<IList<Vehicle>> Handle(GetVehicleByNameQuery request, CancellationToken cancellationToken)
        => await repository.GetVehicleByNameAsync(request.Name, cancellationToken);
}