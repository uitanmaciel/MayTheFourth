using MayTheFourth.Application.Planets.Responses;

namespace MayTheFourth.Application.Planets.Interfaces.Services;

public interface IPlanetServices
{
    Task<Result<IList<PlanetResponse>>> GetPlanetsAsync(CancellationToken cancellationToken = default);
    Task<Result<IList<PlanetResponse>>> GetPlanetByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<Result<PlanetResponse>> GetPlanetByCodeAsync(int code, CancellationToken cancellationToken = default);
}