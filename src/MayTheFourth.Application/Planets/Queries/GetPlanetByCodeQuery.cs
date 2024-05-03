namespace MayTheFourth.Application.Planets.Queries;

public record GetPlanetByCodeQuery(int Id) : IRequest<Planet>;