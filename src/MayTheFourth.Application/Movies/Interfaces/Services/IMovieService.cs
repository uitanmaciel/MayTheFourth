namespace MayTheFourth.Application.Movies.Interfaces.Services;

public interface IMovieService
{
    Task<Result<MovieModel>> SearchByTitle(string title, CancellationToken cancellationToken = default);
    Task<Result<List<MovieModel>>> SearchByDirector(string director, CancellationToken cancellationToken = default);
    Task<Result<MovieModel>> SearchByReleaseDate(DateTime releaseDate, CancellationToken cancellationToken = default);
    Task<Result<List<MovieModel>>> SearchAllMovies(CancellationToken cancellationToken = default);
}