namespace MayTheFourth.Application.Vehicles.Queries;

public record SearchByModelQuery(string Model) : IRequest<VehicleModel>;
