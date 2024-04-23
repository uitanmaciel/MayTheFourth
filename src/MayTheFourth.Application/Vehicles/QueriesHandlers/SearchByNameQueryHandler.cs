using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.Application.Vehicles.Queries;

namespace MayTheFourth.Application.Vehicles.QueriesHandlers;
public class SearchByNameQueryHandler(IVehicleRepository vehicleState) : IRequestHandler<SearchByNameQuery, VehicleModel>
{
    public async Task<VehicleModel> Handle(SearchByNameQuery request, CancellationToken cancellationToken)
        => await vehicleState.SearchByName(request.Name, cancellationToken);    
}
