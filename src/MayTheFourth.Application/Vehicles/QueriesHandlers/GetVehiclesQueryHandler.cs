using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.Application.Vehicles.Queries;

namespace MayTheFourth.Application.Vehicles.QueriesHandlers;

public class GetVehiclesQueryHandler(IVehicleRepository repository) : IRequestHandler<GetVehiclesQuery, IList<Vehicle>>
{
    public async Task<IList<Vehicle>> Handle(GetVehiclesQuery request, CancellationToken cancellationToken)
        => await repository.GetVehiclesAsync(request.Skip, request.Take, cancellationToken);
}