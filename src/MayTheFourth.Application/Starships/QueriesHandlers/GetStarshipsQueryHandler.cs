using MayTheFourth.Application.Starships.Interfaces.State;
using MayTheFourth.Application.Starships.Queries;

namespace MayTheFourth.Application.Starships.QueriesHandlers;

public class GetStarshipsQueryHandler(IStarshipRepository repository) : IRequestHandler<GetStarshipsQuery, IList<Starship>>
{
    public async Task<IList<Starship>> Handle(GetStarshipsQuery request, CancellationToken cancellationToken)
        => await repository.GetStarshipsAsync(request.Skip, request.Take, cancellationToken);
}