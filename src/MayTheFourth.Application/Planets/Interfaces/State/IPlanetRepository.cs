namespace MayTheFourth.Application.Planets.Interfaces.State;

public interface IPlanetRepository
{
    Task<IList<Planet>> GetPlanetsAsync(CancellationToken cancellationToken = default);
    Task<IList<Planet>> GetPlanetByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<Planet> GetPlanetByCodeAsync(int code, CancellationToken cancellationToken = default);
}