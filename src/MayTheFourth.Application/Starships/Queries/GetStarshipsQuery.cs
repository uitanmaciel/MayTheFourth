namespace MayTheFourth.Application.Starships.Queries;

public record GetStarshipsQuery() : IRequest<IList<Starship>>;