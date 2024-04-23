using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.Application.Vehicles.Queries;

namespace MayTheFourth.Application.Vehicles.QueriesHandlers;

public class SearchByClassQueryHandler(IVehicleRepository vehicleState) : IRequestHandler<SearchByClassQuery, VehicleModel>
{
    public async Task<VehicleModel> Handle(SearchByClassQuery request, CancellationToken cancellationToken)
        => await vehicleState.SearchByClass(request.Class, cancellationToken);
}
