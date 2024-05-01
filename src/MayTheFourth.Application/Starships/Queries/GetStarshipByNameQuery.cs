namespace MayTheFourth.Application.Starships.Queries;

public record GetStarshipByNameQuery(string Name) : IRequest<IList<Starship>>;