namespace MayTheFourth.Application.Vehicles.Queries;

public record GetVehiclesQuery() : IRequest<IList<Vehicle>>;