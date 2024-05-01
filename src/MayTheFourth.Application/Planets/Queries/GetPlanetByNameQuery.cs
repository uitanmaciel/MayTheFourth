namespace MayTheFourth.Application.Planets.Queries;

public record GetPlanetByNameQuery(string Name) : IRequest<IList<Planet>>;