using MayTheFourth.Application.Vehicles.Interfaces.State;
using MayTheFourth.Application.Vehicles.Queries;

namespace MayTheFourth.Application.Vehicles.QueriesHandlers;

internal class ListAllQueryHandler(IVehicleRepository vehicleState) : IRequestHandler<ListAllQuery, List<VehicleModel>>
{
    public async Task<List<VehicleModel>> Handle(ListAllQuery request, CancellationToken cancellationToken)
        => await vehicleState.ListAll(cancellationToken);
}
