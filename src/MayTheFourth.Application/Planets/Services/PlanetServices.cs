using MayTheFourth.Application.Planets.Interfaces.Services;
using MayTheFourth.Application.Planets.Queries;
using MayTheFourth.Application.Planets.Responses;

namespace MayTheFourth.Application.Planets.Services;

public class PlanetServices(ISender mediator) : IPlanetServices
{
    public async Task<Result<IList<PlanetResponse>>> GetPlanetsAsync(CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetPlanetsQuery(), cancellationToken);
        if (response is null) return Result<IList<PlanetResponse>>.Failure(Error.NotFound);
        return Result<IList<PlanetResponse>>.Ok(Planet.ToResponse(response));
    }

    public async Task<Result<IList<PlanetResponse>>> GetPlanetByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetPlanetByNameQuery(name), cancellationToken);
        if (response is null) return Result<IList<PlanetResponse>>.Failure(Error.NotFound);
        return Result<IList<PlanetResponse>>.Ok(Planet.ToResponse(response));
    }

    public async Task<Result<PlanetResponse>> GetPlanetByCodeAsync(int code, CancellationToken cancellationToken = default)
    {
        var response = await mediator.Send(new GetPlanetByCodeQuery(code), cancellationToken);
        if (response is null) return Result<PlanetResponse>.Failure(Error.NotFound);
        return Result<PlanetResponse>.Ok(Planet.ToResponse(response));
    }
}