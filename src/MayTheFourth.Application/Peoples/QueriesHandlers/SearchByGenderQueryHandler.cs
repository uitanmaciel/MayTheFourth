using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

public class SearchByGenderQueryHandler(IPeopleRepository peopleState) : IRequestHandler<SearchByGenderQuery, PeopleModel>
{
    public async Task<PeopleModel> Handle(SearchByGenderQuery request, CancellationToken cancellationToken)
        => await peopleState.SearchByGender(request.Gender, cancellationToken);
}
