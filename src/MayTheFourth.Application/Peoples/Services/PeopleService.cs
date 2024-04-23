using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Peoples.Interfaces.Services;
using MayTheFourth.Application.Peoples.Queries;
using MediatR;
using System.Xml.Linq;

namespace MayTheFourth.Application.Peoples.Services;

public class PeopleService(IMediator mediator) : IPeopleService
{
    public async Task<Result<List<PeopleModel>>> ListAll(CancellationToken cancellationToken = default)
    {
        var people = await mediator.Send(new ListAllQuery(), cancellationToken);
        if (people is null)
            return Result<List<PeopleModel>>.Failure(Error.NotFound);

        return Result<List<PeopleModel>>.Ok(people);
    }

    public async Task<Result<PeopleModel>> SearchByGender(string gender, CancellationToken cancellationToken = default)
    {
        var people = await mediator.Send(new SearchByGenderQuery(gender), cancellationToken);
        if (people is null)
            return Result<PeopleModel>.Failure(Error.NotFound);

        return Result<PeopleModel>.Ok(people);
    }

    public async Task<Result<PeopleModel>> SearchByHeight(string height, CancellationToken cancellationToken = default)
    {
        var people = await mediator.Send(new SearchByHeightQuery(height), cancellationToken);
        if (people is null)
            return Result<PeopleModel>.Failure(Error.NotFound);

        return Result<PeopleModel>.Ok(people);
    }

    public async Task<Result<PeopleModel>> SearchById(int id, CancellationToken cancellationToken = default)
    {
        var people = await mediator.Send(new SearchByIdQuery(id), cancellationToken);
        if (people is null)
            return Result<PeopleModel>.Failure(Error.NotFound);

        return Result<PeopleModel>.Ok(people);
    }

    public async Task<Result<PeopleModel>> SearchByName(string name, CancellationToken cancellationToken = default)
    {
        var people = await mediator.Send(new SearchByNameQuery(name), cancellationToken);
        if (people is null)
            return Result<PeopleModel>.Failure(Error.NotFound);

        return Result<PeopleModel>.Ok(people);
    }
}
