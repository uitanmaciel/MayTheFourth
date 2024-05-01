namespace MayTheFourth.Application.Starships.Interfaces.State;

public interface IStarshipRepository
{
    Task<IList<Starship>> GetStarshipsAsync(CancellationToken cancellationToken = default);
    Task<IList<Starship>> GetStarshipByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<IList<Starship>> GetStarshipByModelAsync(string model, CancellationToken cancellationToken = default);
    Task<IList<Starship>> GetStarshipByClassAsync(string @class, CancellationToken cancellationToken = default);
}