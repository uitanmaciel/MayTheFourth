using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.Application.Vehicles.Queries;

namespace MayTheFourth.Application.Vehicles.QueriesHandlers;

public class SearchByIdQueryHandler(IVehicleRepository vehicleState) : IRequestHandler<SearchByIdQuery, VehicleModel>
{
    public async Task<VehicleModel> Handle(SearchByIdQuery request, CancellationToken cancellationToken)
        => await vehicleState.SearchById(request.Id, cancellationToken);
}
