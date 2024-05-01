using MayTheFourth.Application.Starships.Responses;

namespace MayTheFourth.Application.Starships.Interfaces.Services;

public interface IStarshipServices
{
    Task<Result<IList<StarshipResponse>>> GetStarshipsAsync(CancellationToken cancellationToken = default);
    Task<Result<IList<StarshipResponse>>> GetStarshipByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<Result<IList<StarshipResponse>>> GetStarshipByModelAsync(string model, CancellationToken cancellationToken = default);
    Task<Result<IList<StarshipResponse>>> GetStarshipByClassAsync(string @class, CancellationToken cancellationToken = default);
}