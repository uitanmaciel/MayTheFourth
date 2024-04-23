namespace MayTheFourth.Application.Vehicles.Queries;

public record SearchByClassQuery(string Class) : IRequest<VehicleModel>;
