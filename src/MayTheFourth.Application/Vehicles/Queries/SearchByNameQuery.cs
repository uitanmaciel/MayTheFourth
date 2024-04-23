namespace MayTheFourth.Application.Vehicles.Queries;

public record SearchByNameQuery(string Name) : IRequest<VehicleModel>;
