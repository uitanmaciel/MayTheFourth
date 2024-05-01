namespace MayTheFourth.Application.Planets.Queries;

public record GetPlanetsQuery() : IRequest<IList<Planet>>;