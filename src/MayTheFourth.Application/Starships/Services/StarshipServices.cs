using MayTheFourth.Application.Starships.Interfaces.Services;
using MayTheFourth.Application.Starships.Queries;
using MayTheFourth.Application.Starships.Responses;

namespace MayTheFourth.Application.Starships.Services;

public class StarshipServices(ISender mediator) : IStarshipServices
{
    public async Task<Result<IList<StarshipResponse>>> GetStarshipsAsync(CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetStarshipsQuery(), cancellationToken);
        if (response is null) return Result<IList<StarshipResponse>>.Failure(Error.NotFound);
        return Result<IList<StarshipResponse>>.Ok(Starship.ToResponse(response));
    }

    public async Task<Result<IList<StarshipResponse>>> GetStarshipByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetStarshipByNameQuery(name), cancellationToken);
        if (response is null) return Result<IList<StarshipResponse>>.Failure(Error.NotFound);
        return Result<IList<StarshipResponse>>.Ok(Starship.ToResponse(response));
    }

    public async Task<Result<IList<StarshipResponse>>> GetStarshipByModelAsync(string model, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetStarshipByModelQuery(model), cancellationToken);
        if (response is null) return Result<IList<StarshipResponse>>.Failure(Error.NotFound);
        return Result<IList<StarshipResponse>>.Ok(Starship.ToResponse(response));
    }

    public async Task<Result<IList<StarshipResponse>>> GetStarshipByClassAsync(string @class, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetStarshipByClassQuery(@class), cancellationToken);
        if (response is null) return Result<IList<StarshipResponse>>.Failure(Error.NotFound);
        return Result<IList<StarshipResponse>>.Ok(Starship.ToResponse(response));
    }
}