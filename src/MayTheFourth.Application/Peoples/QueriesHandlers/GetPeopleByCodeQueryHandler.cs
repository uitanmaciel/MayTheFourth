using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

public class GetPeopleByCodeQueryHandler(IPeopleRepository repository) : IRequestHandler<GetPeopleByCodeQuery, People>
{
    public async Task<People> Handle(GetPeopleByCodeQuery request, CancellationToken cancellationToken)
        => await repository.GetPeopleByCodeAsync(request.Code, cancellationToken);
}