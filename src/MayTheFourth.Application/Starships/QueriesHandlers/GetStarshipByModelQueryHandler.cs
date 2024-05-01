using MayTheFourth.Application.Starships.Interfaces.State;
using MayTheFourth.Application.Starships.Queries;

namespace MayTheFourth.Application.Starships.QueriesHandlers;

public class GetStarshipByModelQueryHandler(IStarshipRepository repository) : IRequestHandler<GetStarshipByModelQuery, IList<Starship>>
{
    public async Task<IList<Starship>> Handle(GetStarshipByModelQuery request, CancellationToken cancellationToken)
        => await repository.GetStarshipByModelAsync(request.Model, cancellationToken);
}