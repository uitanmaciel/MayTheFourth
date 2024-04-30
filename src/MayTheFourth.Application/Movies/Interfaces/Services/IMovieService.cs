using MayTheFourth.Application.Movies.Responses;

namespace MayTheFourth.Application.Movies.Interfaces.Services;

public interface IMovieService
{
    Task<Result<IList<MovieResponse>>> SearchByTitleAsync(string title, CancellationToken cancellationToken = default);
    Task<Result<IList<MovieResponse>>> SearchByDirectorAsync(string director, CancellationToken cancellationToken = default);
    Task<Result<IList<MovieResponse>>> SearchByProducerAsync(string producer, CancellationToken cancellationToken = default);
    Task<Result<IList<MovieResponse>>> SearchByReleaseDateAsync(string releaseDate, CancellationToken cancellationToken = default);
    Task<Result<IList<MovieResponse>>> GetAllAsync(CancellationToken cancellationToken = default);
}