namespace MayTheFourth.Application.Planets.Queries;

public record GetPlanetByCodeQuery(int Code) : IRequest<Planet>;