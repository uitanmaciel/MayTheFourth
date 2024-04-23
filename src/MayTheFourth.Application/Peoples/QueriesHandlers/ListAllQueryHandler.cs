using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

internal class ListAllQueryHandler(IPeopleRepository peopleState) : IRequestHandler<ListAllQuery, List<PeopleModel>>
{
    public async Task<List<PeopleModel>> Handle(ListAllQuery request, CancellationToken cancellationToken)
        => await peopleState.ListAll(cancellationToken);
}
