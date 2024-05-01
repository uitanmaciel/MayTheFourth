namespace MayTheFourth.Application.Vehicles.Queries;

public record GetVehicleByModelQuery(string Model) : IRequest<IList<Vehicle>>;