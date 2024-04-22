namespace MayTheFourth.Application.Movies.Interfaces.Services;

public interface IMovieService
{
    Task<Result<MovieModel>> SearchByTitle(string title, CancellationToken cancellationToken = default);
    Task<Result<MovieModel>> SearchByDirector(string director, CancellationToken cancellationToken = default);
    Task<Result<MovieModel>> SearchByProducer(string producer, CancellationToken cancellationToken = default);
    Task<Result<MovieModel>> SearchByReleaseDate(DateTime releaseDate, CancellationToken cancellationToken = default);
    Task<Result<MovieModel>> SearchAllMovies(CancellationToken cancellationToken = default);
}