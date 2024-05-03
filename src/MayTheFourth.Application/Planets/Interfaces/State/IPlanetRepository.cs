namespace MayTheFourth.Application.Planets.Interfaces.State;

public interface IPlanetRepository
{
    Task<IList<Planet>> GetPlanetsAsync(int? skip, int? take, CancellationToken cancellationToken = default);
    Task<IList<Planet>> GetPlanetByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<Planet> GetPlanetByIdAsync(int id, CancellationToken cancellationToken = default);
}