namespace MayTheFourth.Application.Starships.Queries;

public record GetStarshipsQuery(int? Skip, int? Take) : IRequest<IList<Starship>>;