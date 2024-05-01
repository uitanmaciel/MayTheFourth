using MayTheFourth.Application.Starships.Interfaces.State;
using MayTheFourth.Application.Starships.Queries;

namespace MayTheFourth.Application.Starships.QueriesHandlers;

public class GetStarshipByNameQueryHandler(IStarshipRepository repository) : IRequestHandler<GetStarshipByNameQuery, IList<Starship>>
{
    public async Task<IList<Starship>> Handle(GetStarshipByNameQuery request, CancellationToken cancellationToken)
        => await repository.GetStarshipByNameAsync(request.Name, cancellationToken);
}