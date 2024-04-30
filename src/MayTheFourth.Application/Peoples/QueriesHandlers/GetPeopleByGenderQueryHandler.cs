using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

public class GetPeopleByGenderQueryHandler(IPeopleRepository repository) : IRequestHandler<GetPeopleByGenderQuery, IList<People>>
{
    public async Task<IList<People>> Handle(GetPeopleByGenderQuery request, CancellationToken cancellationToken)
        => await repository.GetPeopleByGenderAsync(request.Gender, cancellationToken);
}