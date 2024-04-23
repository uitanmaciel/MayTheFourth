namespace MayTheFourth.Application.Vehicles.Queries;

public record ListAllQuery() : IRequest<List<VehicleModel>>;
