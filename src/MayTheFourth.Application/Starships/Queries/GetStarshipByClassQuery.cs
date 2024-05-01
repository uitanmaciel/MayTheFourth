namespace MayTheFourth.Application.Starships.Queries;

public record GetStarshipByClassQuery(string Class) : IRequest<IList<Starship>>;