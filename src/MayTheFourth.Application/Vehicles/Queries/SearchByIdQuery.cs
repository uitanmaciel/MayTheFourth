namespace MayTheFourth.Application.Vehicles.Queries;

public record SearchByIdQuery(int Id) : IRequest<VehicleModel>;
