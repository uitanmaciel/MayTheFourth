namespace MayTheFourth.Application.Starships.Queries;

public record GetStarshipByModelQuery(string Model) : IRequest<IList<Starship>>;