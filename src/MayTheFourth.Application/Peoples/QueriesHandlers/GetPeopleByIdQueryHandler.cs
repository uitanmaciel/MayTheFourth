using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples.Queries;

namespace MayTheFourth.Application.Peoples.QueriesHandlers;

public class GetPeopleByIdQueryHandler(IPeopleRepository repository) : IRequestHandler<GetPeopleByIdQuery, People>
{
    public async Task<People> Handle(GetPeopleByIdQuery request, CancellationToken cancellationToken)
        => await repository.GetPeopleByIdAsync(request.Id, cancellationToken);
}