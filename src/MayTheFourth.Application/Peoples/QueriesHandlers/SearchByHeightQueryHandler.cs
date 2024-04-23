using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

public class SearchByHeightQueryHandler(IPeopleRepository peopleState) : IRequestHandler<SearchByHeightQuery, PeopleModel>
{
    public async Task<PeopleModel> Handle(SearchByHeightQuery request, CancellationToken cancellationToken)
        => await peopleState.SearchByHeight(request.Height, cancellationToken);
}
