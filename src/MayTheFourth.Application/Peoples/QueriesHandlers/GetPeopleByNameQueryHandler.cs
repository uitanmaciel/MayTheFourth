using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

public class GetPeopleByNameQueryHandler(IPeopleRepository repository) : IRequestHandler<GetPeopleByNameQuery, IList<People>>
{
    public async Task<IList<People>> Handle(GetPeopleByNameQuery request, CancellationToken cancellationToken)
        => await repository.GetPeopleByNameAsync(request.Name, cancellationToken);
}