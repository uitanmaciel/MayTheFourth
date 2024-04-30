using MayTheFourth.Application.Peoples.Interfaces.Services;
using MayTheFourth.Application.Peoples.Queries;
using MayTheFourth.Application.Peoples.Responses;

namespace MayTheFourth.Application.Peoples.Services;

public class PeopleServices(ISender mediator) : IPeopleServices
{
    public async Task<Result<IList<PeopleResponse>>> GetPeoplesAsync(CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetPeopleQuery(), cancellationToken);
        if(response is null) return Result<IList<PeopleResponse>>.Failure(Error.NotFound);
        return Result<IList<PeopleResponse>>.Ok(People.ToResponse(response));
    }

    public async Task<Result<PeopleResponse>> GetPeopleByCodeAsync(int code, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetPeopleByCodeQuery(code), cancellationToken);
        if(response is null) return Result<PeopleResponse>.Failure(Error.NotFound);
        return Result<PeopleResponse>.Ok(People.ToResponse(response));
    }

    public async Task<Result<IList<PeopleResponse>>> GetPeopleByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetPeopleByNameQuery(name), cancellationToken);
        if(response is null) return Result<IList<PeopleResponse>>.Failure(Error.NotFound);
        return Result<IList<PeopleResponse>>.Ok(People.ToResponse(response));
    }

    public async Task<Result<IList<PeopleResponse>>> GetPeopleByGenderAsync(string gender, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetPeopleByGenderQuery(gender), cancellationToken);
        if(response is null) return Result<IList<PeopleResponse>>.Failure(Error.NotFound);
        return Result<IList<PeopleResponse>>.Ok(People.ToResponse(response));
    }
}