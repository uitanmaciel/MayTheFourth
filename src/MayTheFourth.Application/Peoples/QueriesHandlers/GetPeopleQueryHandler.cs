using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

public class GetPeopleQueryHandler(IPeopleRepository repository) : IRequestHandler<GetPeopleQuery, IList<People>>
{
    public async Task<IList<People>> Handle(GetPeopleQuery request, CancellationToken cancellationToken)
        => await repository.GetPeoplesAsync(request.Skip, request.Take, cancellationToken);
}