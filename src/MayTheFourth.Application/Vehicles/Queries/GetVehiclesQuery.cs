namespace MayTheFourth.Application.Vehicles.Queries;

public record GetVehiclesQuery(int? Skip, int? Take) : IRequest<IList<Vehicle>>;