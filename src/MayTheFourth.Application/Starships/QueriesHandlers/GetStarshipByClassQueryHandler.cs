using MayTheFourth.Application.Starships.Interfaces.State;
using MayTheFourth.Application.Starships.Queries;

namespace MayTheFourth.Application.Starships.QueriesHandlers;

public class GetStarshipByClassQueryHandler(IStarshipRepository repository) : IRequestHandler<GetStarshipByClassQuery, IList<Starship>>
{
    public async Task<IList<Starship>> Handle(GetStarshipByClassQuery request, CancellationToken cancellationToken)
        => await repository.GetStarshipByClassAsync(request.Class, cancellationToken);
}