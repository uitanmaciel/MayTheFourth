namespace MayTheFourth.Application.Vehicles.Queries;

public record GetVehicleByNameQuery(string Name) : IRequest<IList<Vehicle>>;