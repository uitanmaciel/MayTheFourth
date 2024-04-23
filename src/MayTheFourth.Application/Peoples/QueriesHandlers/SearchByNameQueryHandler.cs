using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

public class SearchByNameQueryHandler(IPeopleRepository peopleState) : IRequestHandler<SearchByNameQuery, PeopleModel>
{
    public async Task<PeopleModel> Handle(SearchByNameQuery request, CancellationToken cancellationToken)
        => await peopleState.SearchByName(request.Name, cancellationToken);    
}
