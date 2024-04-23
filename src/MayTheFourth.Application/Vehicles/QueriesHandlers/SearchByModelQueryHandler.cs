using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.Application.Vehicles.Queries;

namespace MayTheFourth.Application.Vehicles.QueriesHandlers;
public class SearchByModelQueryHandler(IVehicleRepository vehicleState) : IRequestHandler<SearchByModelQuery, VehicleModel>
{
    public async Task<VehicleModel> Handle(SearchByModelQuery request, CancellationToken cancellationToken)
        => await vehicleState.SearchByModel(request.Model, cancellationToken);
}
