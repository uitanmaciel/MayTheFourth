using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

public class SearchByIdQueryHandler(IPeopleRepository peopleState) : IRequestHandler<SearchByIdQuery, PeopleModel>
{
    public async Task<PeopleModel> Handle(SearchByIdQuery request, CancellationToken cancellationToken)
        => await peopleState.SearchById(request.Id, cancellationToken);
}
