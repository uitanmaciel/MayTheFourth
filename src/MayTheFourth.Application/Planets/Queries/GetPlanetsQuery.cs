namespace MayTheFourth.Application.Planets.Queries;

public record GetPlanetsQuery(int? Skip, int? Take) : IRequest<IList<Planet>>;