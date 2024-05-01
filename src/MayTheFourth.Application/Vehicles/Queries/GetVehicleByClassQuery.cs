namespace MayTheFourth.Application.Vehicles.Queries;

public record GetVehicleByClassQuery(string Class) : IRequest<IList<Vehicle>>;